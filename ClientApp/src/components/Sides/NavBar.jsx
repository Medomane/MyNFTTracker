import React from 'react';

const NavBar = ({ handleToggleSidebar }) => {
    return(
        <nav className="navbar navbar-dark" style={{"backgroundColor": "#1d1d1d"}}>
            <button onClick={handleToggleSidebar} className="navbar-toggler  m-1" type="button">
                <span className="navbar-toggler-icon"></span>
            </button>
        </nav>
    );
}

export default NavBar;