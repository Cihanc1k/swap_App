using System;
using System.Collections.Generic;
using System.Text;

namespace Yazilim129.CORE.Model
{
    public class ResultModel
    {
        public ResultModel(ResultType type,string message)
        {
            Type = type;
            Message = message;
        }
        public ResultType Type { get; set; }
        public string Message { get; set; }
    }

    public class ResultModel<T> : ResultModel
    {
        public ResultModel(T data,ResultType type, string message) : base(type, message)
        {
            Data = data;
        }

        public T Data { get; set; }
    }

    public enum ResultType
    {
        Success=1,Warning,Error
    }
}
