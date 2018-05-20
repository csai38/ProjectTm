using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTm.EppmWs.EPSService;
using ProjectTm.EppmWs.ProjectService;
using ProjectTm.EppmWs.WBSService;
using ProjectTm.EppmWs.ActivityService;
using Exchange = Microsoft.Exchange.WebServices.Data;
using System.Diagnostics;

namespace ProjectTm
{
    public partial class Form1 : Form
    {
        private EppmConnection eppmConnection { set; get; }
        private bool isEppmConnect = false;
        private List<int> selProjects= new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //taskTypeDataGridViewTextBoxColumn

            // TODO: данная строка кода позволяет загрузить данные в таблицу "ptmDs.pcm_milstones". При необходимости она может быть перемещена или удалена.
            this.pcm_milstonesTableAdapter.Fill(this.ptmDs.pcm_milstones);
            MessageBox.Show(Properties.Settings.Default.testParams);

        }

        private void eppmConnectBtn_Click(object sender, EventArgs e)
        {
            if (!isEppmConnect)
            {
                LoginEppm win = new LoginEppm();
                win.OnEppmConnected += Win_OnEppmConnected;
                win.Show();
            }
            else
            {
                using (EppmWs.AuthenticationService.AuthenticationService client = new EppmWs.AuthenticationService.AuthenticationService())
                {
                    client.Url = String.Format("{0}/p6ws/services/AuthenticationService", Properties.Settings.Default.EppmWsUrl);
                    client.CookieContainer = eppmConnection.sessionCookie;
                    client.LogoutCompleted += Client_LogoutCompleted;
                    //TODO Добавить установку сервера из параметров
                    client.LogoutAsync("");
                }
            }
        }

        private void Client_LogoutCompleted(object sender, EppmWs.AuthenticationService.LogoutCompletedEventArgs e)
        {
            if (e.Result.Return)
            {
                this.isEppmConnect = false;
                this.eppmConnectBtn.Text = "Подключиться EPPM";
                this.eppmStatusConnection.Text = "EPPM Отключено";
                this.projectTree.Nodes.Clear();
                this.projectTree.Enabled = false;
            }
        }

        private void Win_OnEppmConnected(EppmConnection eppmConnection)
        {
            this.eppmConnection = eppmConnection;
            this.eppmConnectBtn.Text = "Отключиться";
            this.isEppmConnect = true;
            this.eppmStatusConnection.Text = String.Format("Подключено к {0}", this.eppmConnection.dbName);
            using (EPSService epsServ = new EPSService())
            {
                epsServ.Url = String.Format("{0}/p6ws/services/EPSService", Properties.Settings.Default.EppmWsUrl);
                epsServ.CookieContainer = eppmConnection.sessionCookie;
                using (ProjectService projServ = new ProjectService())
                {
                    projServ.Url = String.Format("{0}/p6ws/services/V1/ProjectService", Properties.Settings.Default.EppmWsUrl);
                    projServ.CookieContainer = eppmConnection.sessionCookie;
                    TreeNode[] treeNodes = _readEPS2Tree(epsServ, null, projServ);
                    if (treeNodes != null)
                    {
                        projectTree.Nodes.AddRange(treeNodes);
                        projectTree.Enabled = true;
                    }
                }
            }
            
        }

        private TreeNode[] _readEPS2Tree(EPSService epss, int? parentObjectId, ProjectService projServ = null)
        {
            
            //epss.CookieContainer = eppmConnection.sessionCookie;
            //string[] fields = new string(["ObjectId", "ParentObjectId", "Id", "Name"]);
            string[] fields = new string[4] { "ObjectId", "ParentObjectId", "Id", "Name" };
            ReadEPS readEPS = new ReadEPS();
            readEPS.Field = new EPSFieldType[4] { EPSFieldType.ObjectId, EPSFieldType.ParentObjectId, EPSFieldType.Id, EPSFieldType.Name };
            readEPS.Filter = (parentObjectId == null) ? "ParentObjectId IS NULL" : String.Format("ParentObjectId = {0}", parentObjectId);
            EPS[] res = epss.ReadEPS(readEPS);
            if (res.Length == 0)
            {
                return null;
            }
            TreeNode[] treeNodes = new TreeNode[res.Length];
            int i = 0;
            foreach (EPS r in res)
            {
                TreeNode nod = new TreeNode();
                nod.Text = r.Name;
                nod.Tag = String.Format("eps-{0}", r.ObjectId);
                
                TreeNode[] nodes = this._readEPS2Tree(epss, r.ObjectId, projServ);
                if (nodes != null)
                {
                    nod.Nodes.AddRange(nodes);
                }
                if (projServ != null)
                {
                        TreeNode[] projs = this._readProjects(projServ, r.ObjectId);
                        if (projs != null)
                        {
                            nod.Nodes.AddRange(projs);
                        }
                }
                nod.Expand();
                treeNodes[i] = nod;
                i++;
            }
            return treeNodes;
        }

        private TreeNode[] _readProjects(ProjectService projServ, int epsId)
        {
            ReadProjects readProjects = new ReadProjects();
            readProjects.Field = new ProjectFieldType[3] { ProjectFieldType.ObjectId, ProjectFieldType.WBSObjectId, ProjectFieldType.Name};
            readProjects.Filter = String.Format("ParentEPSObjectId = {0}", epsId);
            Project[] res = projServ.ReadProjects(readProjects);
            if (res.Length == 0)
            {
                return null;
            }
            TreeNode[] treeNodes = new TreeNode[res.Length];
            for (int i = 0; i < res.Length; i++)
            {
                TreeNode nod = new TreeNode();
                nod.Text = res[i].Name;
                nod.Tag = String.Format("proj-{0}-{1}", res[i].ObjectId, res[i].WBSObjectId);
                treeNodes[i] = nod;
            }
            return treeNodes;
        }

        private void projectTree_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode treeNode = e.Node;
            if (treeNode.Tag.ToString().Split('-')[0] == "eps") e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exchange.ExchangeService eService = new Exchange.ExchangeService(Exchange.ExchangeVersion.Exchange2007_SP1);
            eService.Credentials = new Exchange.WebCredentials("bot@bi.tks.ms", "sFx2Dobay");
            eService.Url = new Uri("https://outlook.office365.com/ews/Exchange.asmx");
            //eService.TimeZone = TimeZoneInfo.Local;
            //eService.ImpersonatedUserId = new Exchange.ImpersonatedUserId(Exchange.ConnectingIdType.SmtpAddress, "ceo@bi.tks.ms");
            Exchange.Task nTask = new Exchange.Task(eService);
            
            Exchange.MessageBody messageBody = new Exchange.MessageBody(Exchange.BodyType.HTML, "Необходимо строчно сделать эту работу");
            
            nTask.Body = messageBody;
            nTask.Subject = "Очень важная задача";
            nTask.Importance = Exchange.Importance.High;
            nTask.StartDate = DateTime.Today.AddDays(1).AddHours(8);
            nTask.IsReminderSet = true;
            nTask.DueDate = DateTime.Today.AddDays(3).AddHours(14);
            nTask.Save(new Exchange.FolderId(Exchange.WellKnownFolderName.Tasks,new Exchange.Mailbox("ceo@bi.tks.ms")));
        }

        private string _dateFilter(DateTime pDate)
        {
            if (this.eppmConnection.dbType == EppmWs.AuthenticationService.DatabaseTypeType.SQLServer){
                return String.Format("CONVERT(datetime,{0},120)",pDate);
            }else{
                return String.Format("TO_DATE({0}, 'yyyy-mm-dd hh24:mi:ss')",pDate);
            }
        }

        private void getMilstonesEppm_Click(object sender, EventArgs e)
        {
            if (selProjects.Count == 0)
            {
                MessageBox.Show("Выберите проекты");
                return;
            }
            using (WBSService wbsService = new WBSService())
            {
                using (ActivityService taskService = new ActivityService())
                {
                    wbsService.Url = String.Format("{0}/p6ws/services/WBSService", Properties.Settings.Default.EppmWsUrl);
                    wbsService.CookieContainer = eppmConnection.sessionCookie;
                    taskService.Url = String.Format("{0}/p6ws/services/ActivityService", Properties.Settings.Default.EppmWsUrl);
                    taskService.CookieContainer = eppmConnection.sessionCookie;
                    ReadAllActivitiesByWBS readTasks = new ReadAllActivitiesByWBS();
                    readTasks.Filter = String.Format("Type IN ('{0}','{1}')", "Start Milestone", "Finish Milestone");
                    //readTasks.Filter = String.Format("Type = '{0}'", "Start Milestone");
                    readTasks.Field = new ActivityFieldType[7] { ActivityFieldType.ProjectObjectId, ActivityFieldType.Id, ActivityFieldType.Type, ActivityFieldType.StartDate, ActivityFieldType.FinishDate, ActivityFieldType.WBSName, ActivityFieldType.Name };
                    Activity[] tasks = null;
                    foreach(int wbsId in selProjects)
                    {
                        readTasks.WBSObjectId = wbsId;
                        tasks = taskService.ReadAllActivitiesByWBS(readTasks);
                        Debug.Write(tasks.Length);
                        if (tasks.Length > 0)
                        {
                            foreach(Activity t in tasks)
                            {
                                string tType = (t.Type == ActivityType.FinishMilestone) ? "E" : "S";
                                DateTime aDate = (t.Type == ActivityType.FinishMilestone) ? t.FinishDate : t.StartDate;
                                ptmDs.pcm_milstones.Addpcm_milstonesRow(t.ProjectObjectId, t.Id, tType, String.Format("{0} :: {1}", t.WBSName, t.Name), aDate, aDate, 0);
                            }
                        }
                    }
                    
                }
            }
        }

        private void projectTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Checked = false;
        }

        private void projectTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            string[] nodTag = e.Node.Tag.ToString().Split('-');
            if (nodTag.Length == 3)
            {
                if (e.Node.Checked)
                {
                    selProjects.Add(Convert.ToInt32(nodTag[2]));
                }
                else
                {
                    selProjects.Remove(Convert.ToInt32(nodTag[2]));
                }
            }
            //selProjects.Add(Convert.ToInt32(e))
        }

        private void milstoneDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (milstoneDgv.Columns[e.ColumnIndex].DataPropertyName == "taskType")
            {
                if(e.Value.ToString() == "E")
                {
                    e.Value = "Веха окончания";
                }
                else
                {
                    e.Value = "Веха начала";
                }
                e.FormattingApplied = true;
            }
        }

        private void testCalendar()
        {
            EppmWs.CalendarService.Calendar calendar = new EppmWs.CalendarService.Calendar();
            EppmWs.CalendarService.CalendarStandardWorkHours workHours = new EppmWs.CalendarService.CalendarStandardWorkHours();
            EppmWs.CalendarService.CalendarStandardWorkHoursWorkTime workTime = new EppmWs.CalendarService.CalendarStandardWorkHoursWorkTime();
            //workTime.
            ProjectService ps = new ProjectService();
            CopyProject cp = new CopyProject();
            
            
        }
    }
}
