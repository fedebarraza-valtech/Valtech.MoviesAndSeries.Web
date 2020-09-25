import Vue from 'vue';
import vuetify from '@plugins/vuetify'; // path to vuetify export

import './scss/main.scss';

import router from '@router';
import store from '@store';
import { sync } from 'vuex-router-sync';
sync(store, router);

import DefaultPage from '@core/Pages/DefaultPage.vue';
import StartPage from '@core/Pages/StartPage.vue';
import NewsPage from '@core/pages/NewsPage.vue';

import SeeNowBlock from '@core/blocks/SeeNowBlock.vue';
import LatestNewsBlock from '@core/blocks/LatestNewsBlock.vue';
import NotFoundBlock from '@core/blocks/NotFoundBlock.vue';

// Pages
Vue.component('StartPageType', StartPage);
Vue.component('NewsPageType', NewsPage);

// Blocks
Vue.component('SeeNowBlockType', SeeNowBlock);
Vue.component('LatestNewsBlockType', LatestNewsBlock);
Vue.component('NotFoundBlock', NotFoundBlock);

// Views
Vue.component('DefaultPage', DefaultPage);

/* eslint-disable-next-line no-unused-vars */
let App = new Vue({
    el: '#App',
    vuetify,
    store,
    router
});
