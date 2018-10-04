<template>
  <div class="vue-leaflet">
    <!-- <v-input type="text" style="position:absolute;z-index:500;top:20px;left:50px;" value="qwertyuisdfghjk"> -->
    <v-text-field v-model="name" :rules="nameRules" label="車號" style="position:absolute;z-index:500;top:00px;left:50px;background-color:white" required></v-text-field>

    <l-map style="width: 100%; height: 480px;" :zoom="zoom" :center="center">
      <l-tile-layer :url="url" :attribution="attribution"></l-tile-layer>
      <l-marker :lat-lng="marker">
        <l-popup :content="text"></l-popup>
      </l-marker>
    </l-map>
  </div>
</template>

<script>
import { LMap, LTileLayer, LMarker, LPopup } from 'vue2-leaflet'

export default {
	name: 'VueLeaflet',
	components: {
		LMap,
		LTileLayer,
		LMarker,
		LPopup
	},
	data() {
		return {
			zoom: 17,
			center: L.latLng(22.627278, 120.301435),
			url: 'http://{s}.tile.osm.org/{z}/{x}/{y}.png',
			attribution:
				'&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors',
			marker: L.latLng(22.627278, 120.301435),
			text: 'this is a markerrrr'
		}
	}
}
</script>

<style scoped>
</style>
