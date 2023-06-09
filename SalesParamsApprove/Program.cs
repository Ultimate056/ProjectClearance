﻿using SalesParamsApprove.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesParamsApprove
{
    static class Program
    {
        public static string srvname = "";
        public static string conn_string = "";
        public static string mainConnection = "";
        public static string mainDBName = "";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //закомментить при сборке
            #region ParametersForDebug
            args = new string[4];

            //args[0] = "EasZakTov";
            //args[1] = "ddfi3)es";
            //args[2] = "real";

            //args[0] = "BoykovDV";
            //args[1] = "boykovdv53";
            //args[2] = "test";

            args[0] = "muhinan";
            args[1] = "muhinan1017";
            args[2] = "test";

            //args[0] = "ermilovaiv";
            //args[1] = "ermilova120";
            //args[2] = "test";

            //args[0] = "PodvorotnikovMS";
            //args[1] = "PodvorotnikovMS3453";
            //args[2] = "real";

            //args[0] = "ZolotuhinAS";
            //args[1] = "ZolotuhinAS490";
            //args[2] = "real";

            //args[0] = "natali";
            //args[1] = "natali123";
            //args[2] = "test";

            //args[0] = "selyutinvd";
            //args[1] = "vd325";
            //args[2] = "test";
            #endregion

            //CommonProperty.LoadDataAppConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                try
                {

                    var arg1 = args[0] == null ? "" : args[0];
                    var arg2 = args[1] == null ? "" : args[1];
                    var arg3 = args[2] == null ? "" : args[2];

                    //UniLogger.WriteLog("", 1, $"{arg1} {arg2} {arg3}");

                    if (arg3.ToLower() == "clon" || arg3.ToLower() == "test")
                    {
                        srvname = @"DBSRV\DBSRV";
                        conn_string = $@"Server={srvname};Database={arg3};Integrated Security=SSPI;Connect Timeout=600";
                    }

                    if (arg3 == "real")
                    {
                        srvname = @"DBSRV2";
                        conn_string = $@"Server={srvname};Database={arg3};Integrated Security=SSPI;Connect Timeout=600";
                    }

                    mainConnection = conn_string;
                    mainDBName = arg3;

                    if (User.LoginUser(arg1.ToLower(), arg2.ToLower()))
                    {
                        var idpost = User.GetPostByUserId(User.Current.IdUser);
                        var isdeveloper = User.InRole(User.Current.IdUser, "Developers");
                        var iscanedit = User.InRole(User.Current.IdUser, "CanCreateEditAssortMatrix");


                        if (isdeveloper || iscanedit) //девелопер или РТК или НОП
                        {
                            Application.Run(new fmMain());
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно прав доступа для запуска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином или паролем не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    UniLogger.WriteLog("", 3, ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Неверные параметры запуска приложения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    internal static class UniLogger
    {
        private static BlockingCollection<string> _blockingCollection;
        private static string _filename = Directory.GetCurrentDirectory() + @"\log\log" + DateTime.Now.ToString("dd MM yy HH mm ss") + ".txt";
        //private static string _filename = @"c:\inetpub\wwwroot\log\log" + DateTime.Now.ToString("dd MM yy HH mm ss") + ".txt";
        private static Task _task;

        static UniLogger()
        {
            _blockingCollection = new BlockingCollection<string>();

            _task = Task.Factory.StartNew(() =>
            {
                using (var streamWriter = new StreamWriter(_filename, true, Encoding.UTF8))
                {
                    streamWriter.AutoFlush = true;

                    foreach (var s in _blockingCollection.GetConsumingEnumerable())
                        streamWriter.WriteLine(s);
                }
            },
            TaskCreationOptions.LongRunning);
        }

        public static void WriteLog(string action, int errorCode, string errorDescription)
        {
            //_blockingCollection.Add($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff")} действие: {action}, код: {errorCode.ToString()}, описание: { errorDiscription} ");
            _blockingCollection.Add(@"[" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + "] тип: " + errorCode.ToString() + " сообщение: " + errorDescription);
        }

        public static void Flush()
        {
            _blockingCollection.CompleteAdding();
            _task.Wait();
        }
    }
}
