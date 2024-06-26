﻿using Microsoft.AspNetCore.Components;
using Pomona.Protos.Cash;
using Pomona.Pwa.Client.Custom;
using Pomona.Pwa.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pomona.Pwa.Client.Pages.Cash
{
    public partial class DailyBase : CustomComponentBase
    {
        public DailyRecords DailyRecords = new();
        [Parameter] public int ItemTypeId { get; set; }
        public DateTime DateTimeToday { get; set; } = DateTime.Today;
        public bool IsDisabled { get; set; } = true;

        public Record Record { get; set; } = new();
        public string CashIn { get; set; }
        public string CashBalance { get; set; }
        public string OthersIn { get; set; }
        public string BalanceOut { get; set; }
        public string BalanceIn { get; set; }
        public string Balance { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                var date = DateTimeToday.ToString(Constants.DateParse);
                DailyRecords = await Clients.Cash().GetDailyRecordsAsync(new RecordsRequest { StartDate = date, EndDate = date });
                SetValues();
            }
            catch (Exception ex)
            {
                var error = $"OnInitializedAsync ExceptionError => {ex.Message} {(ex.InnerException != null ? $"InnerExceptionError => {ex.InnerException.Message}" : "")}";
                Console.WriteLine(error);
            }
        }

        private void SetValues()
        {
            var cashIn = DailyRecords.Items.Where(x => x.PaymentMethod.Equals("EFECTIVO") && x.RecordType.Equals("INGRESO")).Sum(x => int.Parse(x.Value));
            var balanceOut = DailyRecords.Items.Where(x => x.RecordType.Equals("EGRESO")).Sum(x => int.Parse(x.Value));
            var othersIn = DailyRecords.Items.Where(x => !x.PaymentMethod.Equals("EFECTIVO") && x.RecordType.Equals("INGRESO")).Sum(x => int.Parse(x.Value));
            var balanceIn = cashIn + othersIn;

            CashIn = cashIn.ToString("C0", CultureInfo);
            BalanceOut = balanceOut.ToString("C0", CultureInfo);
            OthersIn = $"< {othersIn.ToString("C0", CultureInfo)} >";
            BalanceIn = balanceIn.ToString("C0", CultureInfo);
            Balance = (balanceIn - balanceOut).ToString("C0", CultureInfo);
            CashBalance = (cashIn - balanceOut).ToString("C0", CultureInfo);
        }

        protected async Task RegisterDailyRecord()
        {
            try
            {
                Record.Date = DateTime.Now.ToString(Constants.DateTimeParse);
                DailyRecords = await Clients.Cash().RegisterDailyRecordAsync(Record);
                SetValues();
                Record = new();
            }
            catch (Exception ex)
            {
                var error = $"RegisterDailyRecord ExceptionError => {ex.Message} {(ex.InnerException != null ? $"InnerExceptionError => {ex.InnerException.Message}" : "")}";
                Console.WriteLine(error);
            }
        }
    }
}