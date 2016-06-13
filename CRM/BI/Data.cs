using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Test
{
   public class Data
    { 
        /// <summary>
        /// IN deze lijst worden momenteel eigengelijk alle werknemers opgeslagen 
        /// </summary> 
        /// TODO: database koppelen zodat de dit niet alleen maar in een lijst bijgehouden kan worden
        public List<IEmployee> employees = new List<IEmployee>();

        /// <summary>
        /// Via data Methode wroden de gebruikers weggeschreven naar 
        /// een '.txt' bestand, debruikers worden op een manier weggescreven 
        /// dat ze direct uitleesbaar zijn bij het importeren 
        /// </summary> 
        /// TODO: De gebruiker zelf het bestand laten kiezen dat uitgelezen wordt door middel van OpenFileDialog
        /// 
        public void Export()
        {
            using (StreamWriter sw = new StreamWriter("Employees.txt"))
            {
                foreach (IEmployee e in employees)
                {
                    if (e is Charity)
                    {
                        sw.WriteLine(e.FirstName);
                        sw.WriteLine(e.SirName);
                        sw.WriteLine(e.Department);
                    }
                    if (e is Paid)
                    {
                        Paid employee = e as Paid; 
                        sw.WriteLine(employee.FirstName);
                        sw.WriteLine(employee.SirName);
                        sw.WriteLine(employee.Department);
                        sw.WriteLine(employee.Salary);

                    }
                } 
            } 
            
        }
        /// <summary>
        ///Met deze functie kunnen verschillende werknemers geïmporteerd worden vanuit 
        /// Een '.txt' bestand, de opmaak van het document moet als volgt zijn: 
        /// voornaam 
        /// achternaam 
        /// functie  
        /// (salaris indien beschikbaar)
        /// </summary> 
        /// TODO De gebruiker zelf het bestand laten kiezen dat uitgelezen wordt door middel van  OpenFileDialog
        public void Import()
        { 
            List<string> EmployeeData = new List<string>(); 
            SaveFileDialog sfd = new SaveFileDialog();
           
            
            using (StreamReader sr = new StreamReader("C:\\Users\\coenv\\Desktop\\employees.txt"))
            {
                while (!sr.EndOfStream)
                {
                        for (int i = 0; i <= 3; i++)
                        {
                            EmployeeData.Add(sr.ReadLine());
                            if (i == 3)
                            {
                                try
                                {
                                    
                                    EmployeeData.Add(sr.ReadLine());
                                    decimal salary = Convert.ToDecimal(EmployeeData[3]);
                                    if (salary > 0)
                                    {
                                        Paid e = new Paid(EmployeeData[0], EmployeeData[1], EmployeeData[2], salary,EmployeeData[3],EmployeeData[4]);
                                        
                                        employees.Add(e as IEmployee);
                    ;
                                    }
                                    else
                                    {
                                        throw new SalaryToLowException(); 
                                    }
                                }
                                catch (Exception E)
                                {
                                    try
                                    {
                                        Charity c = new Charity(EmployeeData[0], EmployeeData[1], EmployeeData[2],EmployeeData[3],EmployeeData[4]);
                                        employees.Add(c as IEmployee);
                                    }
                                    catch (ArgumentOutOfRangeException e)
                                    {
                                        break;
                                    }
                                }   
                               
                                
                                EmployeeData.Clear();
                            }
                    }

                } 
            }
        }



    }
}
