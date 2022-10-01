import useAuth from '../Auth/UseAuth';

const Dashboard = (props) => {
    const {auth} = useAuth();
    return (<h1>Dashboard of {auth.username}</h1>);
}
 
export default Dashboard;