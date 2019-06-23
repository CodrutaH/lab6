﻿using Lab2.DTOs;
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Servies
{
    public interface IExpenseInterface
    {
        PaginatedList<GetExpenseDto> GetAll(int page, DateTime? from = null, DateTime? to = null, TypeEnum? type = null);

        Expense GetById(int id);

        Expense Create(PostExpenseDto expenseDto, User addedBy);
        Expense Upsert(int id, Expense expense);

        Expense Delete(int id);
    }
}
