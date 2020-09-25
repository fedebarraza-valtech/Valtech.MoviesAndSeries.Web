/**
 * The main vuex store. This holds the state of the URL and makes sure that
 * when the URL is updated, the model gets updated too.
 */

import Vue from 'vue';
import Vuex from 'vuex';

// the module handling model state
import epiDataModel from '@store/modules/epiDataModel';

// the module handling episerver specific state
//import epiContext from '@store/modules/epiContext';

// the module handling app specific state
//import appContext from '@store/modules/appContext';

Vue.use(Vuex);

const store = new Vuex.Store({
    modules: {
        epiDataModel
    }
});

export default store;
