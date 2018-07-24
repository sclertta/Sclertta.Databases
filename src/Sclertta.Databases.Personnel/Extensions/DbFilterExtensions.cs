using Microsoft.EntityFrameworkCore;
using Sclertta.Databases.Personnel;
using Sclertta.Databases.Personnel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sclertta.Databases.Personnel
{
    public static class DbFilterExtensions
    {
        public static Period FindByYearAndMonth(this IQueryable<Period> periods, int year, int month)
        {
            var result = periods
                .SingleOrDefault(x => x.Year == year && x.Month == month);
            return result;
        }

        public static VTypePayment FindPaymentByObjectName(this IQueryable<VTypePayment> vTypePayments, string @object)
        {
            var result = vTypePayments
                .SingleOrDefault(x => x.IdTypeObject == ObjectTypeEnum.PAYMENT.Code && x.Object == @object);
            return result;
        }

        public static Status FindByCode(this IQueryable<Status> statuses, string statusCode)
        {
            var result = statuses.SingleOrDefault(x => x.Code == statusCode);
            return result;
        }

        public static Person FindByDocument(this IQueryable<Person> persons, string documentNumber)
        {
            var result = persons.SingleOrDefault(x => x.DocumentNumber == documentNumber);
            return result;
        }

        public static VEntity FindByCode(this IQueryable<VEntity> entities, string entityCode)
        {
            var result = entities.SingleOrDefault(x => x.Code == entityCode);
            return result;
        }
    }
}
