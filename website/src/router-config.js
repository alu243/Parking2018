import Home from './components/Home';
import HelloWorld from './components/HelloWorld';
import MapSearch from './components/MapSearch';

export const routes = [{
    path: '/',
    component: Home,
    children: [],
}, {
    path: '/HelloWorld',
    component: HelloWorld
}, {
    path: '/MapSearch',
    component: MapSearch
}];