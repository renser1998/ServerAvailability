using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerAvailability
{
   
    public partial class MainForm : Form
    {
        Server myServer=new Server();

        public MainForm()
        {
            InitializeComponent();
            LoadServersConfigFromFile("Servers.txt");

            myServer = GetLocalAddress().FirstOrDefault() ;
            tabPageCondition.MouseWheel += TabPageCondition_MouseWheel;
        }

        private void TabPageCondition_MouseWheel(object sender, MouseEventArgs e)
        {
            tabPageCondition.Invalidate();
        }

        List<Server> servers = new List<Server>();
        public List<Server> GetLocalAddress()
        {
            List<Server> toret = new List<Server>();
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                return null;
            var host = Dns.GetHostEntry(Dns.GetHostName());            
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    toret.Add(new Server() { Ip = ip.ToString(), Name = "Undefined", State = true , FIO="Undefined"});
                    Console.WriteLine(ip.ToString());
                }
            }
            return toret;
        }
        string getStringTime(DateTime time)
        {
            var now = time;
            string h, m, s;
            h = (now.Hour <= 9) ? "0" + now.Hour.ToString() : now.Hour.ToString();
            m = (now.Minute <= 9) ? "0" + now.Minute.ToString() : now.Minute.ToString();
            s = (now.Second <= 9) ? "0" + now.Second.ToString() : now.Second.ToString();
            return h + ":" + m + ":" + s;
        }
        List<Arm> butServers = new List<Arm>();
        private void butServ_click(object sender, EventArgs e)
        {
            var but = ((Arm)sender);
            int tag = (int)but.Tag;
            AddServer ad = new AddServer(servers[tag].Name, servers[tag].Ip, servers[tag].FIO, servers[tag].KindId,servers[tag].Priority);
            if (ad.ShowDialog()== DialogResult.OK)
            {
                //int tag = (int)but.Tag;
                servers[tag].Ip = ad.textBoxIP.Text;
                servers[tag].Name = ad.textBoxNameServ.Text;
                servers[tag].FIO = ad.textBoxFio.Text;
                servers[tag].KindId = ad.comboBoxKind.SelectedIndex;
                servers[tag].Priority = ad.comboBoxProir.SelectedIndex;
                butServers[tag].ArmName = servers[tag].Name;
                butServers[tag].ArmIp =  servers[tag].Ip;
                butServers[tag].ArmPicture = (Bitmap)rm.GetObject(servers[tag].KindId.ToString());
                butServers[tag].Priority = servers[tag].Priority;
                SaveServersConfigToFile("Servers.txt", servers);
            }
        }
        float GetRadFromAngle(float angle)
        {
           return (float)(Math.PI * angle) / (float)180;
        }
        ResourceManager rm = Properties.Resources.ResourceManager;
        void DisplayServers()
        {
            butServers.Clear();
            tabPageCondition.Controls.Clear();
            if (servers.Count>0)
            {
            int radius = (int)(tabPageCondition.Height / 4);
                Size size = new Size(90, 100);
            Point start = new Point(tabPageCondition.Width / 2 -size.Width/2, tabPageCondition.Height / 2 -size.Height/2+40);
            int n = servers.Count - 1;
            int k = (n >= 9) ? (((n / 2)%2>0)?n/2+1:n/2) : n;
            
            bool second = false;
            servers[0].IdTag = 0;
                Arm but = new Arm() { Size = size, ArmName = servers[0].Name, ArmIp = servers[0].Ip, Tag = 0, Location = start, ArmPicture = (Bitmap)rm.GetObject(servers[0].KindId.ToString()) };
                but.Click += butServ_click;
            butServers.Add(but);
            tabPageCondition.Controls.Add(butServers[0]);
            //Graphics g = tabPageCondition.CreateGraphics();
            for (int i = 1; i < servers.Count(); i++)
            {
                 but = new Arm();
                but.ArmName = servers[i].Name;
                but.ArmIp = servers[i].Ip;
                float angle = GetRadFromAngle(360 /k);
                double sin = Math.Sin(angle * (i));
                double cos = Math.Cos(angle * (i));
                int x = start.X + (int)Math.Round((sin) * radius) ;
                int y = start.Y + (int)Math.Round((cos) * radius);
                but.Location = new Point(x, y);
                but.Size = size;
                but.Click += butServ_click;
                but.Tag = i;
                servers[i].IdTag = i;
                but.ArmPicture = (Bitmap)rm.GetObject(servers[i].KindId.ToString());
                butServers.Add(but);
                tabPageCondition.Controls.Add(butServers[butServers.Count()-1]);
                if (i>=k && !second)
                {
                    radius += (int)(tabPageCondition.Height / 5);
                        second = true;
                }

            }
                DrawServerLines();
            }
          
            timer2.Start();
        }
        void DrawServer()
        {
            if (butServers.Count() == 0) return;
            bool second = false;
            int n = servers.Count - 1;
            int k = (n >= 9) ? (((n / 2) % 2 > 0) ? n / 2 + 1 : n / 2) : n;
            int radius = (int)(tabPageCondition.Height/4);
            Size size = new Size(90, 100);
            Point start = new Point(tabPageCondition.Width / 2 - size.Width / 2, tabPageCondition.Height / 2 - size.Height / 2 + 40);
            butServers[0].Location = start;
            for (int i = 1; i < servers.Count(); i++)
            {
                float angle = GetRadFromAngle(360 / k);
                double sin = Math.Sin(angle * (i));
                double cos = Math.Cos(angle * (i));
                int x = start.X + (int)Math.Round((sin) * radius);
                int y = start.Y + (int)Math.Round((cos) * radius);
                butServers[i].Location = new Point(x, y);
                if (i >= k && !second)
                {
                    radius += (int)(tabPageCondition.Height / 5);
                    second = true;
                }
            }
        }
        void DrawServerLines()
        {
            if (butServers.Count>0)
            {
            
                Graphics g = tabPageCondition.CreateGraphics();
                
                Size size = new Size(100, 50);
                Point start = new Point(butServers[0].Left, butServers[0].Top+ butServers[0].Height/2);
                butServers[0].Priority = servers[0].Priority;
                for (int i = 1; i < servers.Count(); i++)
                {

                    g.DrawLine(new Pen(Brushes.Black, 1), start.X + (size.Width / 2), start.Y, butServers[i].Left, butServers[i].Top + size.Height / 2);
                    butServers[i].Priority = servers[i].Priority;
                }
                g.Dispose();
            }
        }
        void SaveServersConfigToFile(string filename, List<Server> listServ)
        {
            List<string> vs = new List<string>();
            for (int i = 0; i < listServ.Count(); i++)
            {
                string line = listServ[i].Ip + "|" + listServ[i].State.ToString() + "|" + listServ[i].Name + "|" +listServ[i].KindId+ "|"+listServ[i].FIO + "|" + listServ[i].Priority.ToString() + "|" + listServ[i].OldState;
                vs.Add(line);
            }
            File.WriteAllLines(Environment.CurrentDirectory + "\\" + filename, vs);
        }
        void LoadServersConfigFromFile(string filename)
        {
            servers.Clear();
            tabPageCondition.Controls.Clear();
            try
            {
                string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "\\" + filename);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] splited = lines[i].Split(new char[] { '|' });
                    servers.Add(new Server(splited[0], Convert.ToBoolean(splited[1]), splited[2], splited[4], int.Parse(splited[3]), int.Parse(splited[5]), Convert.ToBoolean(splited[6])));
                }
                if (servers.Count() > 0)
                {
                    servers[0].My = true;
                    servers[0].Name = "Мой компьютер";
                    servers[0].KindId = 0;
                }
                AddServersToListView(servers);
                DisplayServers();
                loadServerStatus();
            }
            catch
            {
                if (MessageBox.Show("Ошибка загрузки конфигурации сохраненных серверов\nПроизвести поиск доступных серверов?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    servers = GetLocalAddress();
                    SaveServersConfigToFile(filename, servers);
                   

                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = getStringTime(DateTime.Now);
        }

        private void gButCondition_Click(object sender, EventArgs e)
        {
            pageControl1.SelectedTab = tabPageCondition;
            
        }

        private void gButSettings_Click(object sender, EventArgs e)
        {
            pageControl1.SelectedTab = tabPageSettings;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void gBut3_Click(object sender, EventArgs e)
        {

        }
   
        private string getPriorityStr(Server server)
        {
            switch (server.Priority)
            {
                case 0:
                    return "Высокий";
                case 1:
                    return "Средний";
                case 2:
                    return "Низкий";
              default:
                    return "Не установлен";
            }
        }
        private string getKindStr(Server server)
        {
            switch (server.KindId)
            {
                case 0:
                    return "Сервер";
                case 1:
                    return "Ноутбук";
                case 2:
                    return "Стационарный ПК";
                case 3:
                    return "Маршрутизатор";
               case 4:
                    return "Коммутатор";
                case 5:
                    return "Телефон";
                default:
                    return "Не установлен";
            }
        }
        void PingServer(object serv)
        {
            Server server = (Server)serv;
            try
            {
                Ping png = new Ping();
             
                PingReply pingReply = png.Send(server.Ip);
                butServers[server.IdTag].ArmEnable = (pingReply.Status == IPStatus.Success);
                server.State = butServers[server.IdTag].ArmEnable;
                if (server.State !=server.OldState && server.State ==false)
                {
                    MessageBox.Show("");
                    //send message
                }
                server.OldState = server.State;
                labelStatus.ForeColor = Color.Green;
            }
            catch
            {
                butServers[server.IdTag].ArmEnable = false;
                server.State = false;
                if (server.State != server.OldState && server.State == false)
                {
                    MessageBox.Show("");
                    string prior=getPriorityStr(server), kind= getKindStr(server);
                   
                   


                    SaveLog(String.Format("[{0}] Приоритет: =={4}==  {1} (Пользователь:{2}  Оборудование:{3})", DateTime.Now, server.Ip, server.FIO, kind, prior));
                    //sendmessage
                }
                server.OldState = server.State;
            }

        }

        void SaveLog(string str)
        {
            StreamWriter sr = new StreamWriter(Environment.CurrentDirectory + "\\" + "log.txt",true, Encoding.Unicode);
            sr.WriteLine(str);
            sr.Close();
        }


        void loadServerStatus()
        {
            CheckForIllegalCrossThreadCalls = false;
            DrawServerLines();
            
            //labelTimeLastUpdate.Text = "Подождите, идет обновление";
            for (int i = 0; i < servers.Count(); i++)
            {
                new Thread(PingServer).Start(servers[i]);
            }
            labelTimeLastUpdate.Text = "Последнее обновление: "+getStringTime(DateTime.Now);
            timer2.Start();
        }
        Thread myThread;
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            //timer2.Stop();
            myThread = new Thread(new ThreadStart(loadServerStatus));
            myThread.Start();


        }

        private void gButAutoFind_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистить список сохраненных серверов и\nи обнаружить новые сервера?\nДа - список будет перезаписан\nНет-в список серверов будут просто добавлены новые обнаруженные","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                //clear
                servers.Clear();
                servers = GetLocalAddress();
                SaveServersConfigToFile("Servers.txt", servers);

            }
            else
            {
                var toadd = GetLocalAddress();
                for (int i = 0; i < servers.Count(); i++)
                    toadd.RemoveAll(x => x.Ip == servers[i].Ip);
                servers.AddRange(toadd);
                SaveServersConfigToFile("Servers.txt", servers);

            }
            AddServersToListView(servers);
            DisplayServers();
            loadServerStatus();
        }

        private void gButAddbyHand_Click(object sender, EventArgs e)
        {
            AddServer ad = new AddServer();
            if (ad.ShowDialog()== DialogResult.OK)
            {
                if (servers.Where(x => x.Ip == ad.textBoxIP.Text).Count() == 0)
                {
                    Server serv = new Server() { Ip = ad.textBoxIP.Text, Name = ad.textBoxNameServ.Text, State = false, My = false, FIO = ad.textBoxFio.Text, KindId = ad.comboBoxKind.SelectedIndex , Priority = ad.comboBoxProir.SelectedIndex };
                    servers.Add(serv);
                    SaveServersConfigToFile("Servers.txt", servers);
                    AddServersToListView(servers);
                    DisplayServers();
                    loadServerStatus();
                }
                else
                    MessageBox.Show("Сервер с таким IP-адресом уже присутствует");
                
            }
        }
        void AddServersToListView(List<Server> servs)
        {
            listView1.Items.Clear();
            
            for(int i = 0; i < servs.Count(); i++)
            {
                ListViewItem lvi = new ListViewItem() { Text = servs[i].Name };
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = servs[i].Ip });
         
                listView1.Items.Add(lvi);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)//////////////////////////////////////
        {
            if (myThread!=null)
            if (myThread.ThreadState == ThreadState.Background)
                myThread.Abort();
            if (servers.Count()>0)
            SaveServersConfigToFile("Servers.txt", servers);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
           // DrawServerLines();
        }

        private void tabPageCondition_Paint(object sender, PaintEventArgs e)
        {
            DrawServerLines();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            DrawServerLines();
        }

        private void tabPageCondition_Resize(object sender, EventArgs e)
        {
            DrawServer();
        }

        private void tabPageCondition_Scroll(object sender, ScrollEventArgs e)
        {
            tabPageCondition.Invalidate();
            //DrawServerLines();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            int y = groupBox1.Height / 6;
            int x = 10;
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), x + 2, y * 2, 10, 10);
            e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(240, 212, 5)), x + 2, y * 3, 10, 10);
            e.Graphics.FillEllipse(new SolidBrush(Color.Gray), x + 2, y * 4, 10, 10);
            e.Graphics.DrawString("Высокий", groupBox1.Font, new SolidBrush(Color.Black), x+ 15, y * 2);
            e.Graphics.DrawString("Средний", groupBox1.Font, new SolidBrush(Color.Black), x + 15, y * 3);
            e.Graphics.DrawString("Низкий", groupBox1.Font, new SolidBrush(Color.Black), x + 15, y * 4);
        }

        private void gBut1_Click(object sender, EventArgs e)
        {
            butServers[0].Priority = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveLog(String.Format("[{0}]:[{1}] Приоритет:={4}= (Пользователь:{2}  Оборудование:{3})", DateTime.Now, servers[0].Ip, servers[0].FIO, getKindStr(servers[0]), getPriorityStr(servers[0])));
        }
    }
    public class Server
    {
        public Server(string Ip, bool State, string Name, string FIO,  int kindId, int priority, bool old)
        {
            this.Ip = Ip;
            this.State = State;
            this.Name = Name;
            this.FIO = FIO;
            this.KindId = kindId;
            this.Priority = priority;
            this.OldState = old;
        }
        public Server()
        {
            this.Ip = "Undefined";
            this.State = false;
            this.Name = "Undefined";
            this.KindId = 0;
            this.FIO = "";
            this.Priority = 3;
        }
        public int Priority { get; set; }
        public int IdTag { get; set; }
        public bool State { get; set; }
        public bool OldState { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public bool My { get; set; }
        public int KindId { get; set; }
        public string FIO { get; set; }
    }
}
