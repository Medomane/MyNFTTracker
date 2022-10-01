import React from 'react';
import useAuth from '../Auth/UseAuth';
import {
  ProSidebar,
  Menu,
  MenuItem,
  SidebarHeader,
  SidebarContent,
  SubMenu,
  SidebarFooter
} from 'react-pro-sidebar';
import { FaTachometerAlt, FaHourglass, FaSearch,FaWallet, FaProjectDiagram, FaImages, FaRegCopy, FaRegImages,FaSignOutAlt } from 'react-icons/fa';
import {useNavigate} from 'react-router-dom';

const SideBar = ({ collapsed }) => {
    const {auth,setAuth} = useAuth();
    const navigate = useNavigate();
        return (
            <ProSidebar breakPoint="md" collapsed={collapsed}>
                <SidebarHeader>
                    <div
                        style={{
                            padding: '24px',
                            fontWeight: 'bold',
                            fontSize: 14,
                            letterSpacing: '1px',
                            overflow: 'hidden',
                            textOverflow: 'ellipsis',
                            whiteSpace: 'nowrap',
                        }}
                    >
                        MySolTracker ({auth.username})
                    </div>
                </SidebarHeader>

                <SidebarContent>
                    <Menu iconShape="circle">
                        <SubMenu title="Dashboards" icon={<FaTachometerAlt />} >
                            <MenuItem icon={<FaHourglass />} onClick={() => { navigate('/'); }}>Real dashboard</MenuItem>
                            <MenuItem icon={<FaSearch />}>Simulated dashboard</MenuItem>
                        </SubMenu>
                        <MenuItem icon={<FaWallet />} onClick={() => { navigate('/wallets'); }}> Wallets</MenuItem>
                    </Menu>
                    <Menu iconShape="circle">
                        <SubMenu title="My collection" icon={<FaRegImages />} >
                            <MenuItem icon={<FaHourglass />}>From my real activity</MenuItem>
                            <MenuItem icon={<FaSearch />}>From my simulated activity</MenuItem>
                            <MenuItem icon={<FaWallet />}>From my wallets</MenuItem>
                        </SubMenu>
                    </Menu>
                    <Menu iconShape="circle">
                        <MenuItem icon={<FaProjectDiagram />}> Projects </MenuItem>
                        <MenuItem icon={<FaImages />}> NonFungibleTokens</MenuItem>
                        <MenuItem icon={<FaRegCopy />}> Other tokens </MenuItem>
                    </Menu>
                </SidebarContent>
                <SidebarFooter style={{ textAlign: 'center' }}>
                    <div className="sidebar-btn-wrapper" style={{ padding: '20px 20px'}}>
                        <div onClick={() => { localStorage.clear(); setAuth({});}} className="sidebar-btn" rel="noopener noreferrer">
                            <FaSignOutAlt />
                            <span style={{ whiteSpace: 'nowrap', textOverflow: 'ellipsis', overflow: 'hidden' }}>
                                Sign out
                            </span>
                        </div>
                    </div>
                </SidebarFooter>
            </ProSidebar>

        );
    }
 
export default SideBar;