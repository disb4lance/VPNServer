using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class VPNConfiguration
    {
        public int Id { get; set; } // Уникальный идентификатор конфигурации
        public int UserId { get; set; } // Идентификатор пользователя
        public VPNProtocol Protocol { get; set; } // Протокол VPN
        public EncryptionLevel EncryptionLevel { get; set; } // Уровень шифрования
        public string CustomSettings { get; set; } // Дополнительные настройки (если есть)
    }

    public enum VPNProtocol
    {
        OpenVPN,
        WireGuard,
        L2TP
    }

    public enum EncryptionLevel
    {
        Bit128,
        Bit256
    }
}
