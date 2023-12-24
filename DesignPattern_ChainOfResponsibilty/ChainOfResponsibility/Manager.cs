using DesignPattern_ChainOfResponsibilty.DAL.Context;
using DesignPattern_ChainOfResponsibilty.DAL.Entities;
using DesignPattern_ChainOfResponsibilty.Models;

namespace DesignPattern_ChainOfResponsibilty.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            ChainOfRespContext context = new ChainOfRespContext();
            if (req.Amount <= 280000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Sezgin Kılıç";
                customerProcess.Description = "Müşterinin talep ettiği kredi tutarı tarafımca ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextAppRover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Sezgin Kılıç ";
                customerProcess.Description = "Müşterinin talep ettiği kredi tutarı tarafımca ödenemediği için işlem bölge müdürüne aktarılmıştır..";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextAppRover.ProcessRequest(req);
            }
        }
    }
}

