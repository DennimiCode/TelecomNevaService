using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using DevExpress.Mvvm.Native;

using TelecomNevaService.Desktop.Commands;
using TelecomNevaService.Desktop.Models;
using TelecomNevaService.Desktop.Views.Pages;

namespace TelecomNevaService.Desktop.ViewModels;

internal class MainWindowViewModel : BaseViewModel
{
    private readonly TelecomNevaServiceModel _context = new();
    private Frame _frame;
    public Window MainWindow { get; set; }

    public Frame Frame
    {
        get => _frame;
        set => _frame ??= value;
    }

    public MainWindowViewModel()
    {
        #region PropImplements

        Users = _context.User
            .Where
            (
                u => u.UserRoleID == 1 ||
                     u.UserRoleID == 2 ||
                     u.UserRoleID == 3 ||
                     u.UserRoleID == 4 ||
                     u.UserRoleID == 5 ||
                     u.UserRoleID == 6 ||
                     u.UserRoleID == 7
            )
            .Join
            (
                _context.UserInfo,
                u => u.UserInfoID,
                ui => ui.ID,
                (u, ui) => new UserRecord
                {
                    Id = u.ID,
                    FirstName = ui.FirstName,
                    Surname = ui.Surname,
                    Patronymic = ui.Patronymic,
                    FullName = ui.Surname + " " + ui.FirstName + " " + ui.Patronymic,
                    BirthDate = ui.BirthDate,
                    PhoneNumber = ui.PhoneNumber,
                    Email = ui.UserEmail,
                    UserRoleId = u.UserRoleID
                }
            ).ToObservableCollection();

        #endregion
    }

    private void BindingOnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        
    }

    #region Commands

    #region UserComboBoxSelectionChangedCommand

    private LambdaCommand _userComboBoxSelectionChangedCommand;
    public LambdaCommand UserComboBoxSelectionChangedCommand =>
        _userComboBoxSelectionChangedCommand ??= new LambdaCommand(obj =>
        {
            switch ((obj as UserRecord)?.UserRoleId)
            {
                case 1:
                    ClientsSectionGridLength = GridLength.Auto;
                    EquipmentManagementSectionGridLength = new GridLength(0);
                    AssetsSectionGridLength = GridLength.Auto;
                    BillingSectionGridLength = GridLength.Auto;
                    ClientsSupportSectionGridLength = new GridLength(0);
                    CrmSectionGridLength = new GridLength(0);
                    break;
                case 2:
                    ClientsSectionGridLength = GridLength.Auto;
                    EquipmentManagementSectionGridLength = GridLength.Auto;
                    AssetsSectionGridLength = GridLength.Auto;
                    BillingSectionGridLength = GridLength.Auto;
                    ClientsSupportSectionGridLength = GridLength.Auto;
                    CrmSectionGridLength = GridLength.Auto;
                    break;
                case 3:
                    ClientsSectionGridLength = GridLength.Auto;
                    EquipmentManagementSectionGridLength = new GridLength(0);
                    AssetsSectionGridLength = new GridLength(0);
                    BillingSectionGridLength = new GridLength(0);
                    ClientsSupportSectionGridLength = new GridLength(0);
                    CrmSectionGridLength = GridLength.Auto;
                    break;
                case 4:
                    ClientsSectionGridLength = GridLength.Auto;
                    EquipmentManagementSectionGridLength = new GridLength(0);
                    AssetsSectionGridLength = new GridLength(0);
                    BillingSectionGridLength = GridLength.Auto;
                    ClientsSupportSectionGridLength = new GridLength(0);
                    CrmSectionGridLength = GridLength.Auto;
                    break;
                case 5:
                    ClientsSectionGridLength = GridLength.Auto;
                    EquipmentManagementSectionGridLength = GridLength.Auto;
                    AssetsSectionGridLength = new GridLength(0);
                    BillingSectionGridLength = new GridLength(0);
                    ClientsSupportSectionGridLength = GridLength.Auto;
                    CrmSectionGridLength = GridLength.Auto;
                    break;
                case 6:
                    ClientsSectionGridLength = GridLength.Auto;
                    EquipmentManagementSectionGridLength = GridLength.Auto;
                    AssetsSectionGridLength = GridLength.Auto;
                    BillingSectionGridLength = new GridLength(0);
                    ClientsSupportSectionGridLength = new GridLength(0);
                    CrmSectionGridLength = GridLength.Auto;
                    break;
                case 7:
                    ClientsSectionGridLength = GridLength.Auto;
                    EquipmentManagementSectionGridLength = GridLength.Auto;
                    AssetsSectionGridLength = new GridLength(0);
                    BillingSectionGridLength = new GridLength(0);
                    ClientsSupportSectionGridLength = GridLength.Auto;
                    CrmSectionGridLength = GridLength.Auto;
                    break;
            }
        });

    #endregion

    #region NavigationButtonClickCommand

    private LambdaCommand _navigationButtonClickCommand;
    public LambdaCommand NavigationButtonClickCommand =>
        _navigationButtonClickCommand ??= new LambdaCommand(obj =>
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
            else
            {
                Frame.Navigate
                (
                    (obj as Button)?.Name switch
                    {
                        "ClientsButton" => new ClientsPage { MainWindow = MainWindow },
                        "EquipmentManagementButton" => new EquipmentManagementPage(),
                        "AssetsButton" => new AssetsPage(),
                        "ClientsSupportButton" => new ClientsSupportPage(),
                        "CrmButton" => new CrmPage(),
                        "UserProfileButton" => new UserProfilePage(),
                        _ => null
                    }
                );
            }
        });

    #endregion

    #endregion

    #region Properties

    private UserRecord _selectedUser;
    private GridLength _clientsSectionGridLength;
    private GridLength _equipmentManagementSectionGridLength;
    private GridLength _assetsSectionGridLength;
    private GridLength _billingSectionGridLength;
    private GridLength _clientsSupportSectionGridLength;
    private GridLength _crmSectionGridLength;

    public ObservableCollection<UserRecord> Users { get; }
    public UserRecord SelectedUser
    {
        get => _selectedUser;
        set
        {
            _selectedUser = value;
            OnPropertyChanged();
        }
    }
    public GridLength ClientsSectionGridLength
    {
        get => _clientsSectionGridLength;
        set
        {
            _clientsSectionGridLength = value;
            OnPropertyChanged();
        }
    }
    public GridLength EquipmentManagementSectionGridLength
    {
        get => _equipmentManagementSectionGridLength;
        set
        {
            _equipmentManagementSectionGridLength = value;
            OnPropertyChanged();
        }
    }
    public GridLength AssetsSectionGridLength
    {
        get => _assetsSectionGridLength;
        set
        {
            _assetsSectionGridLength = value;
            OnPropertyChanged();
        }
    }
    public GridLength BillingSectionGridLength
    {
        get => _billingSectionGridLength;
        set
        {
            _billingSectionGridLength = value;
            OnPropertyChanged();
        }
    }
    public GridLength ClientsSupportSectionGridLength
    {
        get => _clientsSupportSectionGridLength;
        set
        {
            _clientsSupportSectionGridLength = value;
            OnPropertyChanged();
        }
    }
    public GridLength CrmSectionGridLength
    {
        get => _crmSectionGridLength;
        set
        {
            _crmSectionGridLength = value;
            OnPropertyChanged();
        }
    }

    #endregion
}