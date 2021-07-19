using System;
using Amido.Stacks.Application.CQRS.ApplicationEvents;
using Amido.Stacks.Core.Operations;

namespace Amido.Stacks.Application.CQRS.Events
{
	public class CategoryDeletedEvent : IApplicationEvent
	{
		public CategoryDeletedEvent(IOperationContext context, Guid menuId, Guid categoryId)
		{
			OperationCode = context.OperationCode;
			CorrelationId = context.CorrelationId;
			MenuId = menuId;
			CategoryId = categoryId;
		}


		public int EventCode => (int)Enums.EventCode.CategoryDeleted;

		public int OperationCode { get; }

		public Guid CorrelationId { get; }

		public Guid MenuId { get; set; }

		public Guid CategoryId { get; set; }
	}
}