import Home from './pages/Home';
import BillSearch from './pages/BillSearch';
import MapSearch from './pages/MapSearch';
import HourStatChart from './pages/HourStatChart';

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
}, {
    path: '/HourStatChart',
    meta: {
        title: '各時段開單比較表'
    },
    component: HourStatChart
}]