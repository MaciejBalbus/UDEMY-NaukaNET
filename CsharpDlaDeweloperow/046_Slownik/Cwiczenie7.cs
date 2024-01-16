using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slownik
{
    public class GradeManager
    {
        Dictionary<string, List<int>> OcenyStudentow = new Dictionary<string, List<int>>();

        public void AddGrade(string studentName, int grade)
        {
            if(this.OcenyStudentow.ContainsKey(studentName))
            {
                OcenyStudentow[studentName].Add(grade);
            }
            else
            {
                OcenyStudentow.Add(studentName, new List<int>());
                OcenyStudentow[studentName].Add(grade);
            }


            Console.WriteLine("W AddGrade");

            // TODO: Uzupełnij implementację metody AddGrade, aby dodawała nową ocenę do listy ocen ucznia.
        }

        public void RemoveGrade(string studentName, int grade)
        {
            if (this.OcenyStudentow.ContainsKey(studentName))
            {
                OcenyStudentow[studentName].Remove(grade);     

            }




            // TODO: Uzupełnij implementację metody RemoveGrade, aby usuwała ocenę z listy ocen ucznia, jeśli istnieje.
        }

        public double CalculateAverageGrade(string studentName)
        {
            double srednia = 0.0;
            double sumaOcen=0.0;
            double iloscOcen=0.0;

            if (this.OcenyStudentow.ContainsKey(studentName))
            {
               List<int> listaOcen = OcenyStudentow[studentName].ToList();

                if(listaOcen.Count == 0) return 0.0;

                foreach (int i in listaOcen) 
                {
                    sumaOcen +=i;
                    iloscOcen++;
                }

                srednia= sumaOcen/iloscOcen;

            }
                return srednia;
        }
    }
}
