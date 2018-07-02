using ProjectTm.EppmWs.ActivityService;
using ProjectTm.EppmWs.EPSService;
using ProjectTm.EppmWs.ProjectService;
using ProjectTm.EppmWs.WBSService;
using ProjectTm.EppmWs.DepService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTm
{
    public partial class PpmSync : Form
    {
        private EppmConnection eppm { set; get; }

        private List<int> selProjects = new List<int>();

        public PpmSync()
        {
            InitializeComponent();
        }

        public PpmSync(EppmConnection eppmConnection)
        {
            InitializeComponent();
            this.eppm = eppmConnection;
        }

        private void PpmSync_Load(object sender, EventArgs e)
        {
            if(eppm == null)
            {
                MessageBox.Show("No eppm Connection");
                return;
            }
            using (EPSService epsServ = new EPSService())
            {
                epsServ.Url = String.Format("{0}/p6ws/services/EPSService", Properties.Settings.Default.EppmWsUrl);
                epsServ.CookieContainer = eppm.sessionCookie;
                using (ProjectService projServ = new ProjectService())
                {
                    projServ.Url = String.Format("{0}/p6ws/services/V1/ProjectService", Properties.Settings.Default.EppmWsUrl);
                    projServ.CookieContainer = eppm.sessionCookie;
                    TreeNode[] treeNodes = _readEPS2Tree(epsServ, null, projServ);
                    if (treeNodes != null)
                    {
                        projectTree.Nodes.AddRange(treeNodes);
                        projectTree.Enabled = true;
                    }
                }
            }

            //using(Code)
        }

        private TreeNode[] _readEPS2Tree(EPSService epss, int? parentObjectId, ProjectService projServ = null)
        {

            //epss.CookieContainer = eppmConnection.sessionCookie;
            //string[] fields = new string(["ObjectId", "ParentObjectId", "Id", "Name"]);
            //string[] fields = new string[4] { "ObjectId", "ParentObjectId", "Id", "Name" };
            ReadEPS readEPS = new ReadEPS();
            readEPS.Field = new EPSFieldType[5] { EPSFieldType.ObjectId, EPSFieldType.ParentObjectId, EPSFieldType.Id, EPSFieldType.Name, EPSFieldType.GUID };
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
                //Sync project DB
                syncProjects(r.ObjectId, null, r.ParentObjectId, r.GUID, true, r.Name);
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
            readProjects.Field = new ProjectFieldType[4] { ProjectFieldType.ObjectId, ProjectFieldType.WBSObjectId, ProjectFieldType.Name, ProjectFieldType.GUID };
            readProjects.Filter = String.Format("ParentEPSObjectId = {0}", epsId);
            Project[] res = projServ.ReadProjects(readProjects);
            if (res.Length == 0)
            {
                return null;
            }
            TreeNode[] treeNodes = new TreeNode[res.Length];
            for (int i = 0; i < res.Length; i++)
            {
                syncProjects(res[i].ObjectId, res[i].WBSObjectId, epsId, res[i].GUID, false, res[i].Name);
                TreeNode nod = new TreeNode();
                nod.Text = res[i].Name;
                nod.Tag = String.Format("proj-{0}-{1}", res[i].ObjectId, res[i].WBSObjectId);
                treeNodes[i] = nod;
            }
            return treeNodes;
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
        }

        private void syncProjects(int projId, int? wbsId, int? parentId, string guid, bool isEPS, string projName)
        {
            PpDsTableAdapters.projectsTableAdapter projectsTableAdapter = new PpDsTableAdapters.projectsTableAdapter();
            if (projectsTableAdapter.CheckByGUID(guid) == 0)
            {
                projectsTableAdapter.Insert(projId, parentId, projName, wbsId, guid, isEPS);
            }
        }

        private void syncOperationBySttings()
        {
            if (selProjects.Count == 0)
            {
                MessageBox.Show("Выберите проекты");
                return;
            }
            if (wbsIsSync.Checked)
            {
                using (WBSService wbsService = new WBSService())
                {
                    using (PpDsTableAdapters.projwbsTableAdapter wbsTab = new PpDsTableAdapters.projwbsTableAdapter())
                    {
                        wbsService.Url = String.Format("{0}/p6ws/services/WBSService", Properties.Settings.Default.EppmWsUrl);
                        wbsService.CookieContainer = eppm.sessionCookie;
                        ReadAllWBS readAllWBS = new ReadAllWBS();
                        readAllWBS.Field = new WBSFieldType[5] { WBSFieldType.ObjectId, WBSFieldType.ParentObjectId, WBSFieldType.ProjectObjectId, WBSFieldType.Name, WBSFieldType.GUID };
                        WBS[] wbses = null;
                        foreach (int wbsId in selProjects)
                        {
                            readAllWBS.ObjectId = wbsId;
                            wbses = wbsService.ReadAllWBS(readAllWBS);
                            foreach (WBS w in wbses)
                            {
                                if (wbsTab.CheckByGUID(w.GUID) == 0)
                                {
                                    wbsTab.Insert(w.ObjectId, w.ParentObjectId, w.ProjectObjectId, w.Name, w.GUID);
                                }
                            }
                        }
                    }
                }
            }
            if (taskIsSync.Checked)
            {
                using (ActivityService taskService = new ActivityService())
                {

                    taskService.Url = String.Format("{0}/p6ws/services/ActivityService", Properties.Settings.Default.EppmWsUrl);
                    taskService.CookieContainer = eppm.sessionCookie;
                    ReadAllActivitiesByWBS readTasks = new ReadAllActivitiesByWBS();
                    //readTasks.Filter = String.Format("Type IN ('{0}','{1}')", "Start Milestone", "Finish Milestone");

                    readTasks.Field = new ActivityFieldType[7] { ActivityFieldType.WBSObjectId, ActivityFieldType.Id, ActivityFieldType.Type, ActivityFieldType.StartDate, ActivityFieldType.FinishDate, ActivityFieldType.WBSName, ActivityFieldType.Name };
                    Activity[] tasks = null;
                    foreach (int wbsId in selProjects)
                    {
                        readTasks.WBSObjectId = wbsId;
                        tasks = taskService.ReadAllActivitiesByWBS(readTasks);
                        Debug.Write(tasks.Length);
                        if (tasks.Length > 0)
                        {
                            foreach (Activity t in tasks)
                            {
                                string tType = (t.Type == ActivityType.FinishMilestone) ? "E" : "S";
                                DateTime aDate = (t.Type == ActivityType.FinishMilestone) ? t.FinishDate : t.StartDate;
                                //ptmDs.pcm_milstones.Addpcm_milstonesRow(t.ProjectObjectId, t.Id, tType, String.Format("{0} :: {1}", t.WBSName, t.Name), aDate, aDate, 0);
                            }
                        }
                    }
                }

                using (RelationshipService relService = new RelationshipService())
                {

                }
            }
        }

        private void syncProjectsBtn_Click(object sender, EventArgs e)
        {
            this.syncOperationBySttings();
        }
    }
}
