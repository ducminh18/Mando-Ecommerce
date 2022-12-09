import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'MandoEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44317/',
    redirectUri: baseUrl,
    clientId: 'MandoEcommerce_App',
    responseType: 'code',
    scope: 'offline_access MandoEcommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44378',
      rootNamespace: 'MandoEcommerce',
    },
  },
} as Environment;
