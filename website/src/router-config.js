import Home from './components/Home';
import BillSearch from './components/BillSearch';
import MapSearch from './components/MapSearch';

export const routes = [{
    path: '/',
    component: Home,
    props: {
        subTitle: ''
    },
    children: [],
}, {
    path: '/BillSearch',
    meta: {
        title: '開單紀錄明細資料'
    },
    component: BillSearch
}, {
    path: '/MapSearch',
    meta: {
        title: '車號停車資料查詢'
    },
    component: MapSearch
}]