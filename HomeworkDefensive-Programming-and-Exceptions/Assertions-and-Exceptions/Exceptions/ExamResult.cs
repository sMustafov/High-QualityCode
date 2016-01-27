using System;
using System.Xml.Schema;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("grade", "The grade cannot be negative");
            }
            this.grade = value;
        }

    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (minGrade < 0)
            {
                throw new ArgumentOutOfRangeException("minGrade", "The min grade cannot be negative");
            }
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (maxGrade <= minGrade)
            {
                throw new ArgumentException("The max grade cannot be smallar then min grade");
            }
            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if (string.IsNullOrEmpty(comments))
            {
                throw new ArgumentNullException("comments", "Comments cannot be null");
            }
            this.comments = value;
        }
    }
}
