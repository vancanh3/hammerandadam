﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Entities
{
    public class QuestionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }

        [MaxLength(10)]
        public string Part { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [MaxLength(255)]
        public string FileMp3 { get; set; }


        [MaxLength(255)]
        public string QuestionName { get; set; }

        [MaxLength(255)]
        public string A { get; set; }

        [MaxLength(255)]
        public string B { get; set; }

        [MaxLength(255)]
        public string C { get; set; }

        [MaxLength(255)]
        public string D { get; set; }

        [MaxLength(20)]
        public string Team { get; set; }

        public ICollection<ExamQuestionEntity> ExamQuestions { get; set; } = new List<ExamQuestionEntity>();
    }
}
