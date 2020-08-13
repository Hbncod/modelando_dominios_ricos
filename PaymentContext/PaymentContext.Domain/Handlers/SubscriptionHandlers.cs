using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Repositories;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandlers : Notifiable, IHandler<CreateBoletoSubscriptionsCommand>
    {
        private readonly IStudentRepository _repository;

        public SubscriptionHandlers(IStudentRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateBoletoSubscriptionsCommand command)
        {
            // verificar se documento já está cadastrado

            //verificar se email já está cadastrado

            //Gerar os VOs

            //Gerar as entidades

            //Aplicar Validações

            //Salvar informações

            //Enviar email de boas vindas

            //Retornar informações

            return new CommandResult(true, "Assinatura realizada com sucesso");
        }
    }
}
