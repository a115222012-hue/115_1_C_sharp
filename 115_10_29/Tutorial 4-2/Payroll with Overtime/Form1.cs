using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    /// <summary>
    /// 薪資與加班費計算表單。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建立薪資計算表單。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算總薪資按鈕的點擊事件。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal BASE_HOURS = 40m; // 基本工時
            const decimal OVERTIME_RATE = 1.5m; // 加班費率
            decimal hoursWorked; // 工作時數
            decimal hourlyPayRate; // 每小時薪資
            decimal grossPay; // 總薪資

            try
            {
                // 取得使用者輸入的工作時數與每小時薪資。
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                // 計算總薪資。
                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    decimal overtimeHours = hoursWorked - BASE_HOURS;
                    grossPay = (BASE_HOURS * hourlyPayRate) + (overtimeHours * hourlyPayRate * OVERTIME_RATE);
                }
                // 顯示總薪資，格式化為貨幣。
                grossPayLabel.Text = grossPay.ToString("C");
            }
            catch (FormatException)
            {
                // 如果輸入格式不正確，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // 如果輸入的數字過大或過小，顯示錯誤訊息。
                MessageBox.Show("輸入的數字超出範圍。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 此處執行工作時數、時薪與加班費的計算。
        }

        /// <summary>
        /// 清除按鈕的點擊事件。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除工作時數、每小時薪資與總薪資欄位的內容。
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將輸入焦點移回工作時數欄位。
            hoursWorkedTextBox.Focus();
        }

        /// <summary>
        /// 離開按鈕的點擊事件。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的薪資計算表單。
            this.Close();
        }
    }
}
