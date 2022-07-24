$(function () {
    var l = abp.localization.getResource('Creator');
    var dataTable = $('#JobInfosTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            /*order: [[1, "asc"]],*/
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(creator.jobSchedule.jobInfo.getList),
            columnDefs: [
                {
                    title: l('JobName'),
                    data: "jobName"
                },
                {
                    title: l('JobGroup'),
                    data: "jobGroup"
                },
                {
                    title: l('JobDescription'),
                    data: "jobDescription"
                },
                {
                    title: l('JobAssemblyName'),
                    data: "jobAssemblyName"
                },
                {
                    title: l('JobNamespace'),
                    data: "jobNamespace"
                },
                {
                    title: l('JobClassName'),
                    data: "jobClassName"
                },
                {
                    title: l('JobStatus'),
                    data: "jobStatus"
                },
                {
                    title: l('StarTime'),
                    data: "starTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: l('EndTime'),
                    data: "endTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: l('NextTime'),
                    data: "nextTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                }
            ]
        })
    );
});
