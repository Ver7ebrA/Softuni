﻿using System;
using System.Globalization;

using Logger.Models.Contracts;
using Logger.Models.Enimerations;

namespace Logger.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, Level level)
        {
            this.Layout = layout;
            this.Level = level;
        }

        public ILayout Layout { get; private set; }

        public Level Level { get; private set; }

        public long MessagesAppended { get; private set; }

        public void Append(IError error)
        {
            string format = this.Layout.Format;

            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;

            string formatedMessage = String.Format(format,
                dateTime.ToString("M/dd/yyyy h:mm:ss tt",
                CultureInfo.InvariantCulture),
                message,
                level.ToString());

            Console.WriteLine(formatedMessage);
            this.MessagesAppended++;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}," +
                $" Layout type: {this.Layout.GetType().Name}," +
                $" Report level: {this.Level.GetType().Name.ToUpper()}," +
                $" Messages appended:{this.MessagesAppended}";
            
        }
    }
}
