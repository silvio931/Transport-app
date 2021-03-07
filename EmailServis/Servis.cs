﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Configuration;
using System.Timers;

namespace EmailServis
{
    partial class Servis : ServiceBase
    {
        private System.Timers.Timer timer1;
        private string timeString;
        public int getCallType;
        ZaposlenikRepozitorij zaposlenikRepozitorij = new ZaposlenikRepozitorij();

        public Servis()
        {
            InitializeComponent();
            int strTime = Convert.ToInt32(ConfigurationSettings.AppSettings["callDuration"]);
            getCallType = Convert.ToInt32(ConfigurationSettings.AppSettings["CallType"]);
            if (getCallType == 1)
            {
                timer1 = new System.Timers.Timer();
                double inter = (double)GetNextInterval();
                timer1.Interval = inter;
                timer1.Elapsed += new ElapsedEventHandler(ServiceTimer_Tick);
            }
            else
            {
                timer1 = new System.Timers.Timer();
                timer1.Interval = strTime * 1000;
                timer1.Elapsed += new ElapsedEventHandler(ServiceTimer_Tick);
            }
        }

        protected override void OnStart(string[] args)
        {
            timer1.AutoReset = true;
            timer1.Enabled = true;
            SendMailService.WriteErrorLog("Service started");
        }

        protected override void OnStop()
        {
            timer1.AutoReset = false;
            timer1.Enabled = false;
            SendMailService.WriteErrorLog("Service stopped");
        }


        private double GetNextInterval()
        {
            timeString = ConfigurationSettings.AppSettings["StartTime"];
            DateTime t = DateTime.Parse(timeString);
            TimeSpan ts = new TimeSpan();
            int x;
            ts = t - System.DateTime.Now;
            if (ts.TotalMilliseconds < 0)
            {
                ts = t.AddDays(1) - System.DateTime.Now;
            }
            return ts.TotalMilliseconds;
        }

        private void SetTimer()
        {
            try
            {
                double inter = (double)GetNextInterval();
                timer1.Interval = inter;
                timer1.Start();
            }
            catch (Exception ex)
            {
            }
        }

        private void ServiceTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (var item in zaposlenikRepozitorij.DohvatiZaposlenikeZaEmail())
            {
                string Msg = "Poštovani " + item.Ime + " " + item.Prezime + System.Environment.NewLine + System.Environment.NewLine + ",Ustanovljeno je kako niste ispunili svoje obaveze te u sutavu postoji ruta čije je očekivano vrijeme dolaska završilo prije 2 dana, no još uvijek nije uneseno stvarno vrijeme dolaska. Molimo provjerite i ispravite neispravnosti!" + System.Environment.NewLine + System.Environment.NewLine + "Srdačan pozdrav";

                SendMailService.SendEmail(item.Email, "Podsjetnik - TransportApp", Msg);
            }

            if (getCallType == 1)
            {
                timer1.Stop();
                System.Threading.Thread.Sleep(1000000);
                SetTimer();
            }
        }
    }
}
