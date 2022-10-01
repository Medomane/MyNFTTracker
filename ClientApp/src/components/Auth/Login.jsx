import React, { useState, useRef, useEffect } from 'react';
import axios from '../../Helpers/axios'
import useAuth from './UseAuth';
import {useLocation, useNavigate} from 'react-router-dom';


const Login = (props) => {
  const {setAuth} = useAuth();

  
  const navigate = useNavigate();
  const location = useLocation();
  const from = location.state?.from?.pathname || "/";

  const usernameRef = useRef();
  const errorRef = useRef(); 
  const sendRef = useRef(); 

  const [username, setUserName] = useState();
  const [password, setPassword] = useState();
  const [errorMsg, setErrorMsg] = useState();
  const [isSubmitting, setSubmitting] = useState(false);

  useEffect(()=>{
    usernameRef.current.focus();
  },[]);

  useEffect(()=>{
    setErrorMsg('');
  },[username,password]);

  const handleSubmit = async(e) => {
    e.preventDefault();


    try{
      setSubmitting(true);
      const headers = {
        headers : {
          'Authorization' : 'Basic '+btoa(username+':'+password),
          'Content-Type':'application/json'
        },
        witheCredentials : true
      };
      const res = await axios.get("/appUsers/login",headers);
      let data = res.data;
      data.headers = headers;
      localStorage.setItem('currentUser',JSON.stringify(data));
      setSubmitting(false);
      setAuth(data);
      navigate(from,{replace : true});
    }
    catch(err){
      if(!err?.response) setErrorMsg("No server response !!!");
      else if(err?.response?.status === 400) setErrorMsg("Missing username or password !!!");
      //else if(err?.response?.status === 401) setErrorMsg("Unauthorized !!!");
      else setErrorMsg("User does not exist !!!");
      errorRef.current.focus();
      setSubmitting(false);
    }
  }

  return (
    <div className="Auth-form-container">
      <form className="Auth-form" onSubmit={handleSubmit}>
        <div className="Auth-form-content">
          <h3 className="Auth-form-title">Sign In</h3>
          <div className={errorMsg ? 'alert alert-warning':'d-none'} ref={errorRef} aria-live="assertive">{errorMsg}</div>
          <div className="form-group mt-3">
            <label>Username</label>
            <input
              type="text"
              className="form-control mt-1"
              placeholder="Enter username"
              onChange={e => setUserName(e.target.value)}
              ref={usernameRef}
              required
              autoComplete="off"
            />
          </div>
          <div className="form-group mt-3">
            <label>Password</label>
            <input
              type="password"
              className="form-control mt-1"
              placeholder="Enter password"
              onChange={e => setPassword(e.target.value)}
              required
            />
          </div>
          <div className="d-grid gap-2 mt-3">
            <button disabled={isSubmitting} type="submit" className="btn btn-primary" ref={sendRef}>
              {isSubmitting && (
                <span className="spinner-grow spinner-grow-sm"></span> 
              )}
              Login
            </button>
          </div>
        </div>
      </form>
    </div>
  )
}

  export default Login;