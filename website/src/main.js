// vue components
import '@babel/polyfill';
import Vue from 'vue';
import Vuex from 'vuex';
import Router from 'vue-router';
//import { sync } from 'vuex-router-sync';
import './plugins/vuetify';

// vue app components
import App from './App.vue';
//import VuexStore from './vuex/store';
import { routes } from './router-config';


Vue.use(Vuex);
Vue.use(Router);



//const store = new Vuex.Store(VuexStore); 
Vue.config.productionTip = false


const router = new Router({
    routes,
    mode: 'history',
});
//sync(store, router);

new Vue({
    router,
    //store,
    render: h => h(App)
}).$mount('#app')