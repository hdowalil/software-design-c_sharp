using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Excercise.Challenge.Cots
{
    class Database
    {
        public static Person[] Data =
        {
            new Person(1,"Tyler","Durden",new DateTime(1970, 8,22),"Paper Street","537",19808,"Bradford"),
            new Person(2,"Marla","Singer",new DateTime(1974, 10,17),"Paper Street","537",19808,"Bradford"),
            new Person(3,"Robert","Paulsen",new DateTime(1971, 7,12),"Paper Street","537",19808,"Bradford"),
            new Person(4,"Richard","Chelser",new DateTime(1968, 1,6),"Elm Street","12/1",48201,"Detroit"),
            new Person(5,"Brandon","Walsh",new DateTime(1969, 8,28),"Wilshire Boulevard","815",90210,"Beverly Hills")
        };
    }
}
