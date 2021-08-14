﻿using DevIO.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();

        void Handle(Notificacao notificacao);
    }
}
