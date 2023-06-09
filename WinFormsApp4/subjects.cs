﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class subjects
    {
        public string Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }
        public int Credits { get => credits; set => credits = value; }
        public string Prerequisite { get => prerequisite; set => prerequisite = value; }
        public string Mandatory { get => mandatory; set => mandatory = value; }
        public string Groupz { get => groupz; set => groupz = value; }

        public int Done { get => done; set => done = value; }

        private int recommend;
        public int Recommend { get => recommend; set => recommend = value; }

        private int opentime;
        public int Opentime { get => opentime; set => opentime = value; }


        private string id;
        private string name;
        private int credits;
        private string prerequisite;
        private string mandatory;
        private string groupz;
        private int done;


        public subjects(string id, string name,int credits, string prerequisite, string mandatory, string groupz, int recommend, int opentime/*, int done*/)
        {
            Id = id;
            Name = name;
            Credits = credits;
            Prerequisite = prerequisite;
            Mandatory = mandatory;
            Groupz = groupz;
            Recommend = recommend;
            Opentime = opentime;
            //Done = done;
        }

        public subjects() { }
    }
}
