import 'bootstrap/dist/css/bootstrap.css';
import './index.scss';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import App from './App';
import * as serviceWorkerRegistration from './serviceWorkerRegistration';
import reportWebVitals from './reportWebVitals';
import { AuthProvider } from './components/Auth/AuthProvider';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

console.log(baseUrl);

ReactDOM.render(  
  <React.StrictMode>
        <BrowserRouter>
            <AuthProvider>
                <Routes>
                    <Route path={baseUrl} element={<App />}></Route>
                </Routes>
            </AuthProvider>
        </BrowserRouter>
    </React.StrictMode>,
  rootElement);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://cra.link/PWA
serviceWorkerRegistration.unregister();

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
