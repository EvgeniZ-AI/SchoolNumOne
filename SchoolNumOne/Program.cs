using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNumOne
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolDbContext())
            {
                var firstClassA = new Class()
                {
                    NameClass = "1A",
                    sum = 5
                };
                var secondClassA = new Class()
                {
                    NameClass = "2A",
                    sum = 3
                };
                var thirdClassA = new Class()
                {
                    NameClass = "3A",
                    sum = 4
                };
                var fourthClassA = new Class()
                {
                    NameClass = "4A",
                    sum = 2
                };

                context.Classes.Add(firstClassA);
                context.Classes.Add(secondClassA);
                context.Classes.Add(thirdClassA);
                context.Classes.Add(fourthClassA);

                var EvgeniR = new Student()
                {
                    Name = "Евгений Рассказов",
                    classId = 1
                };
                var AleksandrV = new Student()
                {
                    Name = "Александр Воскресенский",
                    classId = 1
                };
                var AlinaB = new Student()
                {
                    Name = "Алина боровкова",
                    classId = 1
                };
                var AleksandrM = new Student()
                {
                    Name = "Александр Мочалин",
                    classId = 1
                };
                var AndreyG = new Student()
                {
                    Name = "Андрей Горбонос",
                    classId = 1
                };

                context.Students.Add(EvgeniR);
                context.Students.Add(AleksandrV);
                context.Students.Add(AlinaB);
                context.Students.Add(AleksandrM);
                context.Students.Add(AndreyG);

                var AlinaG = new Student()
                {
                    Name = "Алина Громова",
                    classId = 2
                };
                var MarinaL = new Student()
                {
                    Name = "Марина Лубеченко",
                    classId = 2
                };
                var TonyP = new Student()
                {
                    Name = "Тоня Папаримова",
                    classId = 2
                };

                context.Students.Add(AlinaG);
                context.Students.Add(MarinaL);
                context.Students.Add(TonyP);

                var TatianaA = new Student()
                {
                    Name = "Татьяна Азарова",
                    classId = 3
                };
                var ElenaK = new Student()
                {
                    Name = "Крюкова Елена",
                    classId = 3
                };
                var TatianaB = new Student()
                {
                    Name = "Татьяна Бондаренко",
                    classId = 3
                };
                var ElenaB = new Student()
                {
                    Name = "Елена Бондарович",
                    classId = 3
                };

                context.Students.Add(TatianaA);
                context.Students.Add(ElenaK);
                context.Students.Add(TatianaB);
                context.Students.Add(ElenaB);

                var AntonSh = new Student()
                {
                    Name = "Антон Шастун",
                    classId = 4
                };
                var ArseniP = new Student()
                {
                    Name = "Арсений Попов",
                    classId = 4
                };

                context.Students.Add(AntonSh);
                context.Students.Add(ArseniP);
            }
            //добавить в каждый класс учеников 
            //добавить каждому ученику оценки
            //вызывать запросы при помощи Linq
        }
    }
}
