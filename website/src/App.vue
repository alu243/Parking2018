<template lang="pug">
v-app
	v-navigation-drawer(persistent :clipped="clipped" :mini-variant="miniVariant" v-model="drawer" fixed :hide-overlay="true" app width="280")
		v-list
			v-list-group(v-for="(item, i) in menus" :key="i" :prepend-icon="item.icon" no-action)
				v-list-tile(slot="activator")
					v-list-tile-content
						v-list-tile-title(v-text="item.title")
				v-list-tile(value="true" v-for="(subitem, j) in item.items" :key="j" :to="{path: subitem.path}")
					v-list-tile-content
						v-list-tile-title(v-text="subitem.title")
	v-toolbar(app :clipped-left="clipped")
		v-toolbar-side-icon(@click.stop="drawer = !drawer")
		v-btn(icon @click.stop="miniVariant = !miniVariant")
			v-icon(v-html="miniVariant ? 'chevron_right' : 'chevron_left'")
		//- v-btn(icon @click.stop="clipped = !clipped")
		//- 	v-icon web
		v-toolbar-title {{title}} {{$route.meta.title ? "-" : ""}} {{$route.meta.title}}
		v-spacer
		v-btn(icon @click.stop="dialog = !dialog")
			v-icon account_circle
	v-content
		v-fade-transition(mode="out-in")
			router-view(class="view")
	v-dialog(v-model="dialog" width="400" style="z-index:1100;")
		login
	v-footer(:fixed="fixed" app)
		span &copy; 2019
</template>

<script>
import Login from './components/Login'

export default {
	name: 'App',
	components: {
		Login
	},
	data() {
		return {
			clipped: true,
			drawer: true,
			fixed: false,
			menus: [
				{
					icon: 'find_in_page',
					title: '資料分析統計',
					items: [
						{ icon: '', title: '車號停車資料查詢', path: '/MapSearch' },
						{ icon: '', title: '開單紀錄明細資料', path: '/BillSearch' },
						{ icon: '', title: '開單人員開單統計表', path: '/' },
						{ icon: '', title: '開單人員開單間距排行表', path: '/' },
						{ icon: '', title: '各路段車位開單資料統計', path: '/' },
						{ icon: '', title: '各路段開單比較表', path: '/' },
						{ icon: '', title: '各時段開單比較表', path: '/HourStatChart' },
						{ icon: '', title: '每日開單自動查勤表', path: '/' }
					]
				},
				{
					icon: 'phonelink_setup',
					title: '設備耗材管理',
					items: [
						{ icon: '', title: 'PDA領機管理' },
						{ icon: '', title: 'PDA還機管理' },
						{ icon: '', title: 'PDA異常還機管理' },
						{ icon: '', title: '設備清冊管理' },
						{ icon: '', title: '設備保養管理' },
						{ icon: '', title: '設備維修管理' },
						{ icon: '', title: '耗材庫存管理' }
					]
				},
				{
					icon: 'cloud',
					title: '資料傳送管理',
					items: [
						{ icon: 'cloud_download', title: '雲端資料下載作業' },
						{ icon: '', title: '開單資料上傳作業' },
						{ icon: '', title: '相關資料下載作業' },
						{ icon: '', title: 'PDA異常資料匯入作業' }
					]
				},
				{
					icon: 'place',
					title: '圖控介面追蹤管理',
					items: [
						{ icon: '', title: '開單人員現有位置追蹤' },
						{ icon: '', title: '開單人員巡場路線追蹤' },
						{ icon: '', title: '路段車位停車現況' },
						{ icon: '', title: '贓車通報位置警示' },
						{ icon: '', title: '高欠費車通報位置警示' }
					]
				},
				{
					icon: 'how_to_reg',
					title: '人事差勤管理',
					items: [
						{ icon: '', title: '開車人員資料管理' },
						{ icon: '', title: '開車人員排班管理' },
						{ icon: '', title: '薪資獎金設定管理' },
						{ icon: '', title: '績效結算薪資作業' }
					]
				}
			],
			miniVariant: false,
			right: true,
			rightDrawer: false,
			title: '停車開單管理系統',
			dialog: false
		}
	}
}
</script>
