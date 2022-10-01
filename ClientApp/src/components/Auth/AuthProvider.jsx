import React, { createContext, useState } from 'react';

const AuthContext = createContext({});

function getInitialState() {
    const currentUser = localStorage.getItem('currentUser')
    return currentUser ? JSON.parse(currentUser) : null
  }

export const AuthProvider = ({children}) => {
    const[auth,setAuth] = useState(getInitialState);

    return (
        <AuthContext.Provider value={{auth,setAuth}} >
            {children}
        </AuthContext.Provider>
    )
}

export default AuthContext;