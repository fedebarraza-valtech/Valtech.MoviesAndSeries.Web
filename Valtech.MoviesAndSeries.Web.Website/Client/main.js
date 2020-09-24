import Vue from 'vue';

import './scss/main.scss';

import router from '@router';
import store from '@store';
import { sync } from 'vuex-router-sync';
sync(store, router);

import DefaultPage from '@core/Pages/DefaultPage.vue';
import StartPage from '@core/Pages/StartPage.vue';

// Core
Vue.component('StartPageType', StartPage);

// Views
Vue.component('DefaultPage', DefaultPage);

/* eslint-disable-next-line no-unused-vars */
new Vue({
    el: '#App',
    store,
    router
});
