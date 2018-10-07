// vue components
import '@babel/polyfill';
import Vue from 'vue';
import axios from 'axios';
import VueAxios from 'vue-axios';
import Vuex from 'vuex';
import Router from 'vue-router';
import CripLoading from "crip-vue-loading";
//import { sync } from 'vuex-router-sync';
import './plugins/vuetify';
import './mockdata';

import DatetimePicker from 'vuetify-datetime-picker';
import 'vuetify-datetime-picker/src/stylus/main.styl';


// vue app components
import App from './App.vue';
//import VuexStore from './vuex/store';
import {
    routes
} from './router-config';
import 'leaflet/dist/leaflet.css';

//import L from 'vue2-leaflet';
Vue.use(Vuex);
Vue.use(VueAxios, axios);
Vue.use(Router);
Vue.use(DatetimePicker);
// If you use "vue-router" and do not disable `applyOnRouter` option
Vue.use(CripLoading, {
    axios
})

//const store = new Vuex.Store(VuexStore); 
Vue.config.productionTip = false

const router = new Router({
    routes,
    mode: 'history',
});
//sync(store, router);

/* leaflet icon */
delete L.Icon.Default.prototype._getIconUrl; // eslint-disable-line no-undef
L.Icon.Default.mergeOptions({ // eslint-disable-line no-undef
    iconRetinaUrl: require('leaflet/dist/images/marker-icon-2x.png'),
    iconUrl: require('leaflet/dist/images/marker-icon.png'),
    shadowUrl: require('leaflet/dist/images/marker-shadow.png'),
});
new Vue({
    router,
    //store,
    render: h => h(App)
}).$mount('#app');