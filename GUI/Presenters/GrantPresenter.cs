using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Interfaces;
using BLL.Services;
using BLL.Services.Interfaces;

namespace GUI.Presenters
{
    public class GrantPresenter
    {
        private readonly IGrantView _view;
        private readonly IPrivilegeService _privilegeService;

        public GrantPresenter(IGrantView view, IPrivilegeService privilegeService)
        {
            _view = view;
            _privilegeService = privilegeService;

            _view.LoadDataRequested += OnLoadDataRequested;
            _view.GrantSystemPrivilegeClicked += OnGrantSystemPrivilege;
            _view.RevokeSystemPrivilegeClicked += OnRevokeSystemPrivilege;
            _view.GrantObjectPrivilegeOnTableClicked += OnGrantObjectPrivilegeOnTable;
            _view.RevokeObjectPrivilegeOnTableClicked += OnRevokeObjectPrivilegeOnTable;
            _view.GrantObjectPrivilegeOnColumnClicked += OnGrantObjectPrivilegeOnColumn;
            _view.RevokeObjectPrivilegeOnColumnClicked += OnRevokeObjectPrivilegeOnColumn;
            _view.GrantRoleClicked += OnGrantRole;
            _view.RevokeRoleClicked += OnRevokeRole;
            _view.TableSelectionChanged += OnTableSelectionChanged;
        }

        private void OnLoadDataRequested(object sender, EventArgs e)
        {
            try
            {
                var users = _privilegeService.GetAllUsers();
                var roles = _privilegeService.GetAllRoles();
                var tables = _privilegeService.GetAllTables();

                _view.LoadGrantees(users, roles);
                _view.LoadSystemPrivileges();
                _view.LoadRoles(roles);
                _view.LoadTables(tables);

                _view.DisplaySystemPrivileges(_privilegeService.GetAllSystemPrivileges());
                _view.DisplayObjectPrivileges(_privilegeService.GetAllObjectPrivileges());
                _view.DisplayRoleGrants(_privilegeService.GetAllRoleGrants());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi tải dữ liệu: " + ex.Message, true);
            }
        }

        private void OnGrantSystemPrivilege(object sender, EventArgs e)
        {
            try
            {
                string grantee = _view.SelectedGrantee;
                string privilege = _view.SelectedPrivilege;

                if (string.IsNullOrWhiteSpace(grantee) || string.IsNullOrWhiteSpace(privilege))
                {
                    _view.ShowMessage("Vui lòng chọn Grantee và Privilege!", true);
                    return;
                }

                _privilegeService.GrantSystemPrivilege(privilege, grantee, _view.WithAdminOption);
                _view.ShowMessage($"Đã GRANT {privilege} cho {grantee} thành công!");
                _view.DisplaySystemPrivileges(_privilegeService.GetAllSystemPrivileges());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi: " + ex.Message, true);
            }
        }

        private void OnRevokeSystemPrivilege(object sender, EventArgs e)
        {
            try
            {
                string grantee = _view.SelectedGrantee;
                string privilege = _view.SelectedPrivilege;

                if (string.IsNullOrWhiteSpace(grantee) || string.IsNullOrWhiteSpace(privilege))
                {
                    _view.ShowMessage("Vui lòng chọn Grantee và Privilege!", true);
                    return;
                }

                _privilegeService.RevokeSystemPrivilege(privilege, grantee);
                _view.ShowMessage($"Đã REVOKE {privilege} từ {grantee} thành công!");
                _view.DisplaySystemPrivileges(_privilegeService.GetAllSystemPrivileges());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi: " + ex.Message, true);
            }
        }

        private void OnGrantObjectPrivilegeOnTable(object sender, EventArgs e)
        {
            try
            {
                string grantee = _view.SelectedGrantee;
                string privilege = _view.SelectedPrivilege;
                string table = _view.SelectedTable;
                string owner = _view.SelectedTableOwner;

                if (string.IsNullOrWhiteSpace(grantee) || string.IsNullOrWhiteSpace(privilege) || string.IsNullOrWhiteSpace(table))
                {
                    _view.ShowMessage("Vui lòng chọn đầy đủ Grantee, Privilege và Table!", true);
                    return;
                }

                _privilegeService.GrantObjectPrivilegeOnTable(privilege, table, owner, grantee, _view.WithGrantOption);
                _view.ShowMessage($"Đã GRANT {privilege} ON {owner}.{table} cho {grantee} thành công!");
                _view.DisplayObjectPrivileges(_privilegeService.GetAllObjectPrivileges());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi: " + ex.Message, true);
            }
        }

        private void OnRevokeObjectPrivilegeOnTable(object sender, EventArgs e)
        {
            try
            {
                string grantee = _view.SelectedGrantee;
                string privilege = _view.SelectedPrivilege;
                string table = _view.SelectedTable;
                string owner = _view.SelectedTableOwner;

                if (string.IsNullOrWhiteSpace(grantee) || string.IsNullOrWhiteSpace(privilege) || string.IsNullOrWhiteSpace(table))
                {
                    _view.ShowMessage("Vui lòng chọn đầy đủ Grantee, Privilege và Table!", true);
                    return;
                }

                _privilegeService.RevokeObjectPrivilegeOnTable(privilege, table, owner, grantee);
                _view.ShowMessage($"Đã REVOKE {privilege} ON {owner}.{table} từ {grantee} thành công!");
                _view.DisplayObjectPrivileges(_privilegeService.GetAllObjectPrivileges());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi: " + ex.Message, true);
            }
        }

        private void OnGrantObjectPrivilegeOnColumn(object sender, EventArgs e)
        {
            try
            {
                string grantee = _view.SelectedGrantee;
                string privilege = _view.SelectedPrivilege;
                string table = _view.SelectedTable;
                string owner = _view.SelectedTableOwner;
                string column = _view.SelectedColumn;

                if (string.IsNullOrWhiteSpace(grantee) || string.IsNullOrWhiteSpace(privilege)
                    || string.IsNullOrWhiteSpace(table) || string.IsNullOrWhiteSpace(column))
                {
                    _view.ShowMessage("Vui lòng chọn đầy đủ Grantee, Privilege, Table và Column!", true);
                    return;
                }

                _privilegeService.GrantObjectPrivilegeOnColumn(privilege, table, owner, column, grantee, _view.WithGrantOption);
                _view.ShowMessage($"Đã GRANT {privilege} ({column}) ON {owner}.{table} cho {grantee} thành công!");
                _view.DisplayObjectPrivileges(_privilegeService.GetAllObjectPrivileges());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi: " + ex.Message, true);
            }
        }

        private void OnRevokeObjectPrivilegeOnColumn(object sender, EventArgs e)
        {
            try
            {
                string grantee = _view.SelectedGrantee;
                string privilege = _view.SelectedPrivilege;
                string table = _view.SelectedTable;
                string owner = _view.SelectedTableOwner;
                string column = _view.SelectedColumn;

                if (string.IsNullOrWhiteSpace(grantee) || string.IsNullOrWhiteSpace(privilege)
                    || string.IsNullOrWhiteSpace(table) || string.IsNullOrWhiteSpace(column))
                {
                    _view.ShowMessage("Vui lòng chọn đầy đủ Grantee, Privilege, Table và Column!", true);
                    return;
                }

                _privilegeService.RevokeObjectPrivilegeOnColumn(privilege, table, owner, column, grantee);
                _view.ShowMessage($"Đã REVOKE {privilege} ({column}) ON {owner}.{table} từ {grantee} thành công!");
                _view.DisplayObjectPrivileges(_privilegeService.GetAllObjectPrivileges());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi: " + ex.Message, true);
            }
        }

        private void OnGrantRole(object sender, EventArgs e)
        {
            try
            {
                string grantee = _view.SelectedGrantee;
                string role = _view.SelectedRole;

                if (string.IsNullOrWhiteSpace(grantee) || string.IsNullOrWhiteSpace(role))
                {
                    _view.ShowMessage("Vui lòng chọn Grantee và Role!", true);
                    return;
                }

                _privilegeService.GrantRole(role, grantee, _view.WithAdminOption);
                _view.ShowMessage($"Đã GRANT {role} cho {grantee} thành công!");
                _view.DisplayRoleGrants(_privilegeService.GetAllRoleGrants());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi: " + ex.Message, true);
            }
        }

        private void OnRevokeRole(object sender, EventArgs e)
        {
            try
            {
                string grantee = _view.SelectedGrantee;
                string role = _view.SelectedRole;

                if (string.IsNullOrWhiteSpace(grantee) || string.IsNullOrWhiteSpace(role))
                {
                    _view.ShowMessage("Vui lòng chọn Grantee và Role!", true);
                    return;
                }

                _privilegeService.RevokeRole(role, grantee);
                _view.ShowMessage($"Đã REVOKE {role} từ {grantee} thành công!");
                _view.DisplayRoleGrants(_privilegeService.GetAllRoleGrants());
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi: " + ex.Message, true);
            }
        }

        private void OnTableSelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string owner = _view.SelectedTableOwner;
                string table = _view.SelectedTable;

                if (string.IsNullOrWhiteSpace(table)) return;

                var columns = _privilegeService.GetColumnsOfTable(owner, table);
                _view.LoadColumns(columns);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Lỗi tải danh sách column: " + ex.Message, true);
            }
        }
    }
}
