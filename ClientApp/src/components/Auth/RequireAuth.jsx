import { useLocation, Navigate, Outlet } from "react-router-dom";
import useAuth from './UseAuth';

const RequireAuth = ({allowedRoles}) => {
    const {auth} = useAuth();
    const location = useLocation();
    return (
        auth?.id ? allowedRoles.includes(auth.role) ? <Outlet /> : <Navigate to='unauthorized' state={{from : location}} replace></Navigate> : <Navigate to='login' state={{from : location}} replace></Navigate>
    )
}
export default RequireAuth;