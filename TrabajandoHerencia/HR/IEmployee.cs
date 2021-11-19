using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajandoHerencia.HR
{
    public interface IEmployee
    {
        double ReceiveWage();
        void GiveBonus();
        void PerforWork();
        void StopWorking();
        void DisplayEmployeeDetails();

        void GiveCompliment();

    }
}
