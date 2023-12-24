using DesignPattern_ChainOfResponsibilty.DAL.Context;
using DesignPattern_ChainOfResponsibilty.DAL.Entities;
using DesignPattern_ChainOfResponsibilty.Models;

namespace DesignPattern_ChainOfResponsibilty.ChainOfResponsibility
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            ChainOfRespContext context = new ChainOfRespContext();
            if (req.Amount <= 200000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Sevilay Öner";
                customerProcess.Description = "Müşterinin talep ettiği kredi tutarı tarafımca ödenmiştir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextAppRover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Sevilay Öner";
                customerProcess.Description = "Müşterinin talep ettiği kredi tutarı tarafımca ödenemediği için işlem şube müdürüne aktarılmıştır..";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextAppRover.ProcessRequest(req);
            }
        }
    }
}
