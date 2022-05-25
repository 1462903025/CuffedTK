using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace CuffedTK
{
    public sealed class Config : IConfig
    {
        [Description("是否应启用该插件？")]
        public bool IsEnabled { get; set; } = true;

        [Description("提示应该向攻击者显示多长时间？（-1=关闭）")]
        public ushort AttackerHintTime { get; set; } = 3;

        [Description("当攻击者试图损坏被捆绑的D-Class时，应该显示什么提示？ %PLAYER% 将替换为目标用户名")]
        public string AttackerHint { get; set; } = "你不能伤害 %PLAYER% ，因为他被捆绑了！";

        [Description("哪支队伍不允许破坏被捆绑的DD！ CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial")]
        public HashSet<Team> DisallowDamagetodclass { get; set; } = new HashSet<Team>
        {
            Team.MTF,
            Team.RSC
        };

        [Description("什么队伍不允许伤害一个被铐起来的科学家！ CDP = Class-D, CHI = Chaos, MTF = Nine-Tailed Fox, RSC = Scientists, TUT = Tutorial")]
        public HashSet<Team> DisallowDamagetoScientists { get; set; } = new HashSet<Team>
        {
            Team.CDP,
            Team.CHI
        };

        [Description("提示应该向攻击者显示多长时间？ (-1 = 关闭)")]
        public int DamageTypesTime { get; set; } = 3;

        [Description("当不允许攻击被捆绑DD的队伍时，应显示什么提示？  %PLAYER% 将替换为目标用户名， %DAMAGETYPE% 将替换为损伤类型")]
        public string DamageTypesMessage { get; set; } = "你不能用 %DAMAGETYPE% 伤害 %PLAYER% ！";

        [Description("什么样的损伤类型不允许损伤戴袖口的D级或戴袖口的科学家？ 打开 https://exiled-team.github.io/EXILED/api/Exiled.API.Enums.DamageType.html 查看 武器内容")]
        public HashSet<DamageType> DisallowedDamageTypes { get; set; } = new HashSet<DamageType>
        {
            DamageType.Explosion,
            DamageType.FriendlyFireDetector,
            DamageType.Falldown
        };
    }
}
