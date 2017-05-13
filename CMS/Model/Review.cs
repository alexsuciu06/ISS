﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Review
    {
        private int idReview;
        private Reviewer reviewer;
        private string grade;
        private Paper paper;
        private Recomandation recomandation;

        public Review(int idReview, Reviewer reviewer, string grade, Paper paper, Recomandation recomandation)
        {
            this.idReview = idReview;
            this.reviewer = reviewer;
            this.grade = grade;
            this.paper = paper;
            this.recomandation = recomandation;
        }
        public Review()
        {
            this.idReview = 1;
            this.reviewer = new Reviewer();
            this.grade = "";
            this.paper = new Paper();
            this.recomandation = new Recomandation();
        }

        public int IdReview
        {
            get
            {
                return idReview;
            }

            set
            {
                idReview = value;
            }
        }

        internal Reviewer Reviewer
        {
            get
            {
                return reviewer;
            }

            set
            {
                reviewer = value;
            }
        }

        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        public Paper Paper
        {
            get
            {
                return paper;
            }

            set
            {
                paper = value;
            }
        }

        public Recomandation Recomandation
        {
            get
            {
                return recomandation;
            }

            set
            {
                recomandation = value;
            }
        }

        public override string ToString()
        {
            return this.idReview + " " + this.reviewer.ToString() + " " + this.grade + " " + this.Paper.ToString() + " " + this.recomandation.ToString();
        }

    }
}