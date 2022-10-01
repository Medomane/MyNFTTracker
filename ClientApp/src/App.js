import React, { Component } from 'react';
import 'react-pro-sidebar/dist/css/styles.css';
import './index.scss';
import { Routes, Route } from "react-router-dom"
import './components/Auth/Auth.css'
import Login from './components/Auth/Login'
import Dashboard from './components/Views/Dashboard';
import Layout from './components/Layout';
import Missing from './components/Commons/Missing';
import RequireAuth from './components/Auth/RequireAuth';
import Unauthorized from './components/Commons/Unauthorized';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Routes>
        <Route path='/' element={<Layout />}>
            <Route path='login' element={<Login />}></Route>
            <Route path='unauthorized' element={<Unauthorized />}></Route>

            <Route element={<RequireAuth allowedRoles={['admin','user']} />}>
              <Route path='/' element={<Dashboard />}></Route>
              <Route path='/Dashboard' element={<Dashboard />}></Route>
            </Route>
            <Route element={<RequireAuth allowedRoles={['admin']} />}>
              {/*for admin users*/}
            </Route>
            <Route path='*' element={<Missing />}></Route>
        </Route>
      </Routes>
    );
    );
  }
}
