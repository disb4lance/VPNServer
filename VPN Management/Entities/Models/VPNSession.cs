using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class VPNSession
    {
        public int Id { get; set; } // Уникальный идентификатор сессии
        public int UserId { get; set; } // Идентификатор пользователя (из микросервиса User Management)
        public int ServerId { get; set; } // Идентификатор VPN-сервера
        public DateTime StartTime { get; set; } // Время начала сессии
        public DateTime? EndTime { get; set; } // Время окончания сессии (null, если активна)
        public long DataUsage { get; set; } // Использование данных в байтах

        // Навигационные свойства (связи)
        public VPNServer VPNServer { get; set; } // Связь с моделью VPNServer
    }
}
