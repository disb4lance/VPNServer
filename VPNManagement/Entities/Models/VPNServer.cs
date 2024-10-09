using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class VPNServer
    {
        public int Id { get; set; } // Уникальный идентификатор сервера
        public string Name { get; set; } // Имя сервера
        public string IP { get; set; } // IP-адрес сервера
        public string Country { get; set; } // Страна расположения
        public int MaxConnections { get; set; } // Максимальное количество подключений
        public int CurrentConnections { get; set; } // Текущее количество подключений
        public VPNServerStatus Status { get; set; } // Статус сервера
    }

    public enum VPNServerStatus
    {
        Active,
        Inactive,
        Maintenance
    }
}
