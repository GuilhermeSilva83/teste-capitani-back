﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Capitani.Domain.Seedwork
{

    public class OperationResult<TData> : OperationResult
    {
        public TData Data { get; set; }

    }


    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static OperationResult Ok<TData>(TData data)
        {
            return new OperationResult<TData>()
            {
                Success = true,
                Message = "Operação Realizada com Sucesso",
                Data = data
            };
        }

        public static OperationResult Ok()
        {
            return new OperationResult()
            {
                Success = true,
                Message = "Operação Realizada com Sucesso",
            };
        }

        public static OperationResult Fail(string message = null)
        {
            return new OperationResult()
            {
                Success = false,
                Message = message
            };
        }
    }
}
