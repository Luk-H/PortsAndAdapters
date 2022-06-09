using LoanstepCore.Entities;
using LoanstepCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoanstepWeb.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditReportController : ControllerBase
{
    private readonly CreditReportService _service;

    public CreditReportController(CreditReportService creditReportService)
    {
        _service = creditReportService;
    }

    [HttpGet(Name = "getCreditReport")]
    public async Task<CreditReportVm> Get(string ssn)
    {
        var report = await _service.GetReportOrCreateIfNeeded(ssn);

        return report.toViewModel();
    }
}