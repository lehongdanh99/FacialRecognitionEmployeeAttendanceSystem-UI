﻿using FacialRecognitionEmployeeAttendanceSystem_UI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacialRecognitionEmployeeAttendanceSystem_UI.Views.ManagementSystem
{
    public partial class frmModifySalaryRules : Form
    {
        public frmModifySalaryRules()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigSalary configSalary = new ConfigSalary();
            configSalary.overTimeSalaryRate = Convert.ToDouble(nudOvertimeSalaryRate.Value);
            configSalary.salaryPerHour = Convert.ToDouble(nudSalaryPerHour.Value);
            configSalary.taxRate = Convert.ToDouble(nudTaxRate.Value);
            configSalary.allowance = Convert.ToDouble(nudAllowance.Value);
            configSalary.bonusPerDay = Convert.ToDouble(nudBonusPerDay.Value);

            using (StreamWriter file = File.CreateText(Config.ConfigFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, configSalary);
                MessageBox.Show("Save successfull!");
            }
        }
    }
}