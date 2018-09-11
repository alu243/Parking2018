import Home from './components/Home';
import HelloWorld from './components/HelloWorld';

export const routes = [{
    path: '/',
    component: Home,
    children: [],
}, {
    path: '/HelloWorld',
    component: HelloWorld
}];