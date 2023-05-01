import React from 'react';

import ReactDOM from 'react-dom/client';

import App from './App';
import { OpenAPI } from './api';

import './index.css';

OpenAPI.BASE = process.env.REACT_APP_BASE_URL ?? '';

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement);
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>,
);
