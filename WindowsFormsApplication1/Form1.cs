using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        private string path = ".\\nginx.conf";
        private string as_start_marker = "#as_start";
        private string as_end_marker = "#as_end";
        private string as_meat_marker = "#as_meat";
        private char[] delimiters = new char[] { ' ', '\t' };

        private string buf_path = ".\\nginx_tmp.conf";

        public Form1()
        {
            InitializeComponent();
        }

        public string[] FilterOutEmptyString(string[] input)
        {
            List<string> availableCars = new List<string>();

            foreach (string c in input)
            {
                if (c.Length > 0)
                    availableCars.Add(c);
            }

            return availableCars.ToArray();
        }

        private void loadPaths()
        {
            lbPathList.Items.Clear();

            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line.ToString());

                int index = line.IndexOf(as_meat_marker);
                if (-1 != index)
                {
                    line = line.Substring(0, index);
                    line = line.Trim();
                    Console.WriteLine("line:" + line);
                    //string[] pieces = line.Split(delimiters);

                    line = line.Replace(';', ' ');
                    string[] pieces = System.Text.RegularExpressions.Regex.Split(line, "\\s+");
                    
                    //pieces.Where(p => p.Length > 0);
                    pieces = FilterOutEmptyString(pieces);

                    foreach (string i in pieces)
                    {
                        Console.WriteLine("piece:" + i);
                    }
                    lbPathList.Items.Add(pieces[1]);
                }
            }
            sr.Close();
        }

        private void savePaths()
        {
            FileStream fs = new FileStream(buf_path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line.ToString());

                int index = line.IndexOf(as_start_marker);
                if (-1 != index)
                {
                    sw.WriteLine(line);

                    ///
                    foreach (string i in lbPathList.Items)
                    {
                        sw.WriteLine("location / {");


                        string new_path = i.Replace('\\', '/');

                        sw.WriteLine("\troot\t" + new_path + ";" + as_meat_marker);
                        sw.WriteLine("}");
                    }

                    ///
                    while (true)
                    {
                        line = sr.ReadLine();
                        if (-1 != line.IndexOf(as_end_marker))
                            break;
                    }
                    ///
                    sw.WriteLine(line);
                }
                else
                {
                    sw.WriteLine(line);
                }

            }
            sr.Close();
            
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();

            //
            File.Delete(path);
            File.Move(buf_path, path);
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.SelectedPath = "D:\\tmp";
            if(fbd .ShowDialog() == DialogResult.OK)
            {
                string selected_path = fbd.SelectedPath;

                lbPathList.Items.Add(selected_path);

                savePaths();
                loadPaths();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPaths();
        }

        private void deletePaths()
        {
            ListBox.SelectedIndexCollection sic = lbPathList.SelectedIndices;//得到选择的Item的下标

            if (sic.Count == 0)
                return;
            else
            {
                //  将选择的Item放入list中
                List<int> list = new List<int>();
                for (int i = 0; i < sic.Count; i++)
                {
                    list.Add(sic[i]);
                }
                list.Sort();//对list进行排序（库里默认的排序结果一般指的是从下到大的排序）

                while (list.Count != 0)//按照下标从大到小的顺序从ListBox控件里删除选择的Item
                //如果这里采用其它顺序则可能破坏下标的有效性
                {
                    lbPathList.Items.RemoveAt(list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                }
            }

            savePaths();
            loadPaths();
        }

        private void btnDeletePaths_Click(object sender, EventArgs e)
        {
            deletePaths();
        }
    }
}
