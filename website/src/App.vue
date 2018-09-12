<template>
	<v-app>
		<v-navigation-drawer persistent :clipped="clipped" v-model="drawer" fixed hide-overlay="false" app width="200">
			<v-list>
				<v-list-group v-for="(item, i) in menus" :key="i" :prepend-icon="item.icon" no-action>
					<v-list-tile slot="activator">
						<v-list-tile-content>
							<v-list-tile-title v-text="item.title"></v-list-tile-title>
						</v-list-tile-content>
					</v-list-tile>
					<v-list-tile value="true" v-for="(subitem, j) in item.items" :key="j" :to="{path: subitem.path}">
						<!-- <v-list-tile-action>
							<v-icon v-html="subitem.icon"></v-icon>
						</v-list-tile-action> -->
						<v-list-tile-content>
							<v-list-tile-title v-text="subitem.title"></v-list-tile-title>
						</v-list-tile-content>
					</v-list-tile>
				</v-list-group>
			</v-list>
		</v-navigation-drawer>
		<v-toolbar app :clipped-left="clipped">
			<v-toolbar-side-icon @click.stop="drawer = !drawer"></v-toolbar-side-icon>
			<v-btn icon @click.stop="miniVariant = !miniVariant">
				<v-icon v-html="miniVariant ? 'chevron_right' : 'chevron_left'"></v-icon>
			</v-btn>
			<v-btn icon @click.stop="clipped = !clipped">
				<v-icon>web</v-icon>
			</v-btn>
			<!-- <v-btn icon @click.stop="fixed = !fixed">
        <v-icon>remove</v-icon>
      </v-btn> -->
			<v-toolbar-title >{{title}}
			<!-- <v-btn flat to="/" exact>{{title}}</v-btn> -->
			</v-toolbar-title>
			<v-spacer></v-spacer>
			<!-- <v-btn icon @click.stop="rightDrawer = !rightDrawer"> -->
			<v-btn icon @click.stop="dialog = !dialog">
				<v-icon>account_circle</v-icon>
			</v-btn>
		</v-toolbar>
		<v-content>
      <v-fade-transition mode="out-in">
        <router-view></router-view>
      </v-fade-transition>
			<!-- <router-view class="view"></router-view> -->
			
			<!-- <HelloWorld/> -->
		</v-content>

		<v-dialog v-model="dialog" width="400">
			<!-- <v-container style="position: relative;top: 5%;" class="text-xs-center"> -->
			<v-layout row class="text-xs-center">
				<v-flex xs4 style="background-image: url('https://cdn.wallpapersafari.com/7/86/gqiGH7.jpg')">
				</v-flex>
				<v-flex xs8>
					<v-card flat>
						<v-card-title primary-title>
							<h4>登入</h4>
						</v-card-title>
						<v-form>
							<v-text-field prepend-icon="person" name="Username" label="帳號"></v-text-field>
							<v-text-field prepend-icon="lock" name="Password" label="密碼" type="password"></v-text-field>
							<v-card-actions>
								<v-btn primary large block @click.stop="dialog = false">登 入
									<v-icon>input</v-icon>
								</v-btn>
							</v-card-actions>
						</v-form>
					</v-card>
					<!-- </v-container> -->
				</v-flex>
			</v-layout>
		</v-dialog>

		<!-- <v-navigation-drawer temporary :right="right" v-model="rightDrawer" fixed app>
      <v-list>
        <v-list-tile @click="right = !right">
          <v-list-tile-action>
            <v-icon>compare_arrows</v-icon>
          </v-list-tile-action>
          <v-list-tile-title>Switch drawer (click me)</v-list-tile-title>
        </v-list-tile>
      </v-list>
    </v-navigation-drawer> -->
		<v-footer :fixed="fixed" app>
			<span>&copy; 2018</span>
		</v-footer>
	</v-app>
</template>

<script>

export default {
	name: 'App',
	components: {
		//HelloWorld
	},
	data() {
		return {
			clipped: true,
			drawer: true,
			fixed: false,
			menus: [
				{
					icon: 'image_search',
					title: '基本查詢',
					items: [
						{ icon: '', title: '停車紀錄查詢', path:'/MapSearch' },
						{ icon: '', title: '人員開單查詢', path:'/HelloWorld' },
						{ icon: '', title: '其他既有資料查詢', path:'/' }
					]
				},
				{
					icon: 'library_books',
					title: '報表分析',
					items: [
						{ icon: '', title: '開單統計' },
						{ icon: '', title: '停車格周轉率' },
						{ icon: '', title: '開單間隔排行' },
						{ icon: '', title: '開單績效轉薪資' }
					]
				},
				{
					icon: 'phonelink_setup',
					title: '資產管理',
					items: [
						{ icon: '', title: '設備管理' },
						{ icon: '', title: '耗材管理' },
						{ icon: '', title: '其他資產' },
						{ icon: '', title: '人員管理' }
					]
				},
				{
					icon: 'schedule',
					title: '排程',
					items: [
						{ icon: '', title: '下載交通局資料' },
						{ icon: '', title: '上傳交通局資料' },
						{ icon: '', title: '下載google相片' },
						{ icon: '', title: '刪除相片' }
					]
				},
				{
					icon: 'map',
					title: 'GIS分析',
					items: [
						{ icon: '', title: '停車空格GIS查詢' },
						{ icon: '', title: '人員開單軌跡' },
						{ icon: '', title: '違規、贓車通報' }
					]
				}
			],
			miniVariant: false,
			right: true,
			rightDrawer: false,
			title: '停管資訊系統',
			dialog: false
		}
	}
}
</script>
