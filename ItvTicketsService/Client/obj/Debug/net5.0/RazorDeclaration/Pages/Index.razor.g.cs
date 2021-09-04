// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ItvTicketsService.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 695 "C:\Users\sachi\Source\Repos\itvticketsservice\ItvTicketsService\Client\Pages\Index.razor"
       
    /// <summary>
    /// name of company
    /// </summary>
    //private int PlantId = 0;
    private string plantName;

    private string btnStatus = "btn btn-primary btn-primary-extended";
    //private int companyTickets;

    public UserInfo CurrentUserInfo;

    //all users
    public List<UserInfo> users;

    //current user
    public List<Plant> plants;
    public List<Device> devices;

    /// <summary>
    /// used by add ticket components
    /// </summary>
    public List<int> userPlants = new List<int>();
    public List<Device> plantDevices = new List<Device>();
    public List<Company> userCompany = new List<Company>();


    public Dictionary<int, string> dictDevices = new Dictionary<int, string>();
    public Dictionary<int, string> dictClients = new Dictionary<int, string>();
    public Dictionary<int, string> dictPlants = new Dictionary<int, string>();
    public Dictionary<int, string> dictDeviceToPlantName = new Dictionary<int, string>();
    public Dictionary<int, int> dictDeviceLine = new Dictionary<int, int>();

    public Dictionary<int, string> dictCompanyName = new Dictionary<int, string>();
    public Dictionary<int, int> dictCompanyTickets = new Dictionary<int, int>();


    public string SelectedDevice = string.Empty;
    public int SelectedClientId = 0;
    public int SelectedPlantId = 0;
    private string SelectedPlant = string.Empty;

    private string searchString1 = "";
    private string searchString2 = "";


    /// <summary>
    /// used to load tickets on page for logged in user's company
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        //load current user tickets
        await _ticketService.Load();

        CurrentUserInfo = await _userinfoService.UserInfo_GetOne(_ticketService.LoggedInUser.UserId);

        if (_ticketService.LoggedInUser.Role.Contains(RoleType.Client))
        {
            //users non serve

            plants = new List<Plant>();
            devices = new List<Device>();

            //current user plants
            foreach (var plantId in CurrentUserInfo.Plants)
            {
                Plant pl = await _plantService.Plant_GetOne(plantId);
                plants.Add(pl);

                var dvc = await _deviceService.GetDevicesForPlant(plantId);
                devices.AddRange(dvc);

                Company cp = await _companyService.Company_GetOne(pl.IdCompany);
                userCompany.Add(cp);
            }
        }
        else
        {
            //lista utenti ruolo client
            users = await _userinfoService.GetUserList(3);
            dictClients = users.Distinct().ToDictionary(x => x.Id, x => x.UserName);

            plants = await _plantService.GetPlantList();

            devices = await _deviceService.GetDeviceList();
        }

        dictPlants = plants.Distinct().ToDictionary(x => x.Id, x => x.Name);
        dictDevices = devices.Distinct().ToDictionary(x => x.Id, x => x.Code);
        dictDeviceLine = devices.Distinct().ToDictionary(x => x.Id, x => x.NumLinea);

        foreach (var cmp in userCompany)
        {
            if (!dictCompanyName.ContainsKey(cmp.Id)) dictCompanyName[cmp.Id] = cmp.Name;
            if (!dictCompanyTickets.ContainsKey(cmp.Id)) dictCompanyTickets[cmp.Id] = cmp.TicketAmount;
        }
        //dictCompanyName = userCompany.Distinct().ToDictionary(x => x.Id, x => x.Name);
        //dictCompanyTickets = userCompany.Distinct().ToDictionary(x => x.Id, x => x.TicketAmount);


        foreach (var dv in devices)
        {
            if (true)/// !dictDeviceToPlantName.ContainsKey(dv.Id))
            {
                if (dictPlants.ContainsKey(dv.PlantId))
                {
                    dictDeviceToPlantName[dv.Id] = dictPlants[dv.PlantId];
                }
            }
        }

        //plantName
        //Plant pl = await _plantService.Plant_GetOne(PlantId);
        //plantName = pl.Name;

        //Company cp = await _companyService.Company_GetOne(pl.IdCompany);
        //companyName = cp.Name;
        //companyTickets = cp.TicketAmount;

        int clientId = _ticketService.LoggedInUser.UserId;

        _ticketService.TickettoInsert.ClientId = clientId;
        _ticketService.TickettoInsert.TeamId = clientId; //to avoid primary key exception
        _ticketService.TickettoInsert.CloserId = clientId; //to avoid primary key exception
    }

    /// <summary>
    /// used to show error message for tickets creation
    /// </summary>
    public string error { get; set; }

    /// <summary>
    /// Add new ticket. takes TickettoInsert as imput which contains tickets data.
    /// </summary>
    /// <returns></returns>
    public async Task AddTicket()
    {
        error = null;
        try
        {
            if (_ticketService.TickettoInsert.ClientId > 0 && _ticketService.TickettoInsert.DeviceId > 0)
            {
                await _ticketService.AddTicket();
                _ticketService.TickettoInsert = new Tickets();

                error = "Ticket added successfully.";
                await OnInitializedAsync();
            }
            else
            {
                if (_ticketService.TickettoInsert.ClientId == -1)
                {
                    error = "Error, Select a client";
                }
                else
                {
                    error = "Error, Select a device";
                }
            }
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

    public async Task UpdateTicket(Tickets ticket, bool updateStatus)
    {
        error = null;

        try
        {
            //ticket current state
            Tickets cTicket = await _ticketService.GetTicketsById(ticket.TicketId);

            bool advanceStatus = true;
            if (updateStatus)
            {
                if (cTicket.TicketStatusId == (int)TicketStatusMaster.ToDo)
                {
                    cTicket.OpenDate = DateTime.Now;
                    cTicket.TeamId = _ticketService.LoggedInUser.UserId;
                    if (_ticketService.LoggedInUser.Role.Contains(RoleType.Client))
                    {
                        cTicket.TicketStatusId = (int)TicketStatusMaster.Aborted;
                        cTicket.TicketStatus = _ticketService.TicketStatuses.First(x => x.TicketStatusId == cTicket.TicketStatusId).TicketStatus;
                        cTicket.CloserId = _ticketService.LoggedInUser.UserId;
                        cTicket.CloseDate = DateTime.Now;
                        advanceStatus = false;
                    }
                }

                if (cTicket.TicketStatusId == (int)TicketStatusMaster.Approve)
                {
                    cTicket.CloserId = _ticketService.LoggedInUser.UserId;
                    cTicket.CloseDate = DateTime.Now;
                }

                if (cTicket.TicketStatusId == (int)TicketStatusMaster.Closed)
                {
                    if (!_ticketService.LoggedInUser.Role.Contains(RoleType.Admin))
                    {
                        advanceStatus = false;
                    }
                }

                if (cTicket.TicketStatusId == (int)TicketStatusMaster.Aborted)
                {
                    if (!_ticketService.LoggedInUser.Role.Contains(RoleType.Admin))
                    {
                        advanceStatus = false;
                    }
                }

                if (advanceStatus)
                {
                    if (cTicket.TicketStatusId != (int)TicketStatusMaster.Aborted)
                    {
                        cTicket.TicketStatusId = ticket.TicketStatusId + 1;
                    }
                    else
                    {
                        //restart loop
                        cTicket.TicketStatusId = (int)TicketStatusMaster.ToDo;
                    }

                    cTicket.TicketStatus = _ticketService.TicketStatuses.First(x => x.TicketStatusId == cTicket.TicketStatusId).TicketStatus;
                }
            }

            //aggiorna ticket
            //ticket = cTicket;

            await _ticketService.UpdateTicket(cTicket, updateStatus);

            error = "Ticket updated successfully.";

            await OnInitializedAsync();
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

    public async Task DeleteTicket(Tickets tk)
    {
        var parameters = new DialogParameters();
        parameters.Add("ContentText", $"Do you really want to delete ticket id={ tk.TicketId }? This process cannot be undone.");
        parameters.Add("ButtonText", "Delete");
        parameters.Add("Color", Color.Error);

        var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        var dialog = _dialogService.Show<ItvModalDialog>("Delete", parameters, options);

        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            error = null;
            try
            {
                await _ticketService.DeleteTicket(tk);

                error = "Ticket deleted successfully.";

                await OnInitializedAsync();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }
    }

    public async Task BuildUserPlants(ChangeEventArgs e)
    {
        userPlants.Clear();
        plantDevices.Clear();

        string usrid = e.Value.ToString();
        int userid = Convert.ToInt32(usrid);

        UserInfo selUser = await _userinfoService.UserInfo_GetOne(userid);

        //copy list
        foreach (var elm in selUser.Plants)
        {
            userPlants.Add(elm);
        }

        _ticketService.TickettoInsert.DeviceId = -1;

        _ticketService.TickettoInsert.ClientId = userid;
        _ticketService.TickettoInsert.TeamId = userid;
        _ticketService.TickettoInsert.CloserId = userid;
    }

    public async Task BuildPlantDevices(ChangeEventArgs e)
    {
        plantDevices.Clear();
        string plid = e.Value.ToString();

        int plantid = Convert.ToInt32(plid);

        plantDevices = await _deviceService.GetDevicesForPlant(plantid);
    }

    protected async Task AddTicketRefresh()
    {
        int k = 0;
        await AddTicket();

        StateHasChanged();
    }

    protected async Task UpdateDeleteTicketRefresh()
    {
        await OnInitializedAsync();

        StateHasChanged();
    }

    protected async Task Refresh()
    {
        StateHasChanged();
    }


    //metodi per ricerca tickets
    private bool MyFilterFunc(Tickets element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Tickets element, string searchString)
    {
        string clientName = "null";
        string deviceName = "null";
        string plantName = "null";

        if (dictClients.ContainsKey(element.ClientId)) clientName = dictClients[element.ClientId];
        if (dictDevices.ContainsKey(element.DeviceId)) deviceName = dictDevices[element.DeviceId];
        if (dictDeviceToPlantName.ContainsKey(element.DeviceId)) plantName = dictDeviceToPlantName[element.DeviceId];

        if (string.IsNullOrWhiteSpace(searchString))
            return true;

        if (element.TicketId.ToString().Equals(searchString))
            return true;

        if (clientName.Equals(searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        if (plantName.Equals(searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        //!!! device name ha spazi...
        if (deviceName.Trim().Equals(searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        //if (deviceName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
        //    return true;

        //if ($"{element.Number} {element.Position} {element.Molar}".Contains(searchString))
        //    return true;

        return false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDeviceService _deviceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlantService _plantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyService _companyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITicketService _ticketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserInfoService _userinfoService { get; set; }
    }
}
#pragma warning restore 1591