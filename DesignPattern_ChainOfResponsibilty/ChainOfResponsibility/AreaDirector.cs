using DesignPattern_ChainOfResponsibilty.DAL.Context;
using DesignPattern_ChainOfResponsibilty.DAL.Entities;
using DesignPattern_ChainOfResponsibilty.Models;

namespace DesignPattern_ChainOfResponsibilty.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            ChainOfRespContext context = new ChainOfRespContext();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Polat Sezgin Yüksel";
                customerProcess.Description = "Müşterinin talep ettiği kredi tutarı tarafımca ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "\"Bölge Müdürü - Polat Sezgin Yüksel";
                customerProcess.Description = "Müşterinin talep ettiği kredi tutar bankanın günlük ödeme limitlerini aştığı için işlem gerçekleştirilemedi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}

