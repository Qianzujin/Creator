using System.ComponentModel;

namespace Creator.JobSchedule
{
    public enum JobStatu:byte
    {
        [Description("执行中")]
        Running,

        [Description("已完成")]
        Completed,

        [Description("已停止")]
        Stopped,

        [Description("系统停止")]
        SystemStopped,

        [Description("已删除")]
        Deleted,
    }
}