using System;
using System.Collections.Concurrent;
using MediatR;
using Tolitech.CodeGenerator.Auditing.Models;
using Tolitech.CodeGenerator.Notification;

namespace Tolitech.CodeGenerator.Auditing.Trail.Commands.InsertItems
{
    public class InsertItemsCommand : Domain.Commands.Command, IRequest<NotificationResult>
    {
        public InsertItemsCommand()
        {
			Items = new ConcurrentQueue<AuditInfo>();
        }

		public ConcurrentQueue<AuditInfo> Items { get; set; }

		public override void Validate()
		{
			var validator = new InsertItemsCommandValidator();
			Validate(validator.Validate(this));
		}
	}
}
